using Metek.Application.Dtos.Mesai.Response;
using Metek.Application.Services.Repositories;
using Metek.Domain.Entities;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metek.Application.Services
{
    public class ShiftCalculatorService
    {
        private readonly IMesaiRepository _mesaiRepository;

        public ShiftCalculatorService(IMesaiRepository mesaiRepository)
        {
            _mesaiRepository = mesaiRepository;
        }

        public async Task<List<ShiftResponse>> CalculateWorkHoursAsync()
        {
            List<Mesai> logs = await _mesaiRepository.GetListAsync();
            var mesaiSonuclari = new List<ShiftResponse>();

            if (logs == null || logs.Count == 0)
                return mesaiSonuclari;

            // Clean up logs based on process status
            var editedMesai = CleanUpLogs(logs);

            mesaiSonuclari = HesaplaMesai(editedMesai);

            return mesaiSonuclari;
        }
        public async Task<List<Mesai>> GetListAsync()
        {
            return await _mesaiRepository.GetListAsync();
        }

        public async Task DeleteAsync(Mesai mesai)
        {
            await _mesaiRepository.DeleteAsync(mesai,true);
        }
        public async Task UpdateAsync(Mesai mesai)
        {
            // Ensure that the mesai exists before attempting to update
            var existingMesai = await _mesaiRepository.GetAsync(q=>q.Id==mesai.Id);
            if (existingMesai == null)
            {
                throw new KeyNotFoundException("Mesai not found.");
            }

            // Update the existing record's properties
            existingMesai.Personel = mesai.Personel;
            existingMesai.ProcessTime = mesai.ProcessTime;
            existingMesai.ProcessStatus = mesai.ProcessStatus;

            await _mesaiRepository.UpdateAsync(existingMesai);
        }
        public async Task AddAsync(Mesai mesai)
        {
            await _mesaiRepository.AddAsync(mesai);
        }
        private List<Mesai> CleanUpLogs(List<Mesai> logs)
        {
            var editedMesai = new List<Mesai>();

            for (int i = 0; i < logs.Count; i++)
            {
                if (editedMesai.Count == 0 || editedMesai.Last().ProcessStatus != logs[i].ProcessStatus)
                {
                    editedMesai.Add(logs[i]);
                }

                if ((i + 1) < logs.Count)
                {
                    List<Mesai> checkList = logs.GetRange(i + 1, logs.Count - (i + 1));
                    foreach (var item in checkList)
                    {
                        if (item.ProcessStatus == logs[i].ProcessStatus)
                        {
                            if (item.ProcessStatus == false)
                            {
                                editedMesai.Last().ProcessTime = item.ProcessTime;
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }

            return editedMesai;
        }

        private List<ShiftResponse> HesaplaMesai(List<Mesai> mesaiListesi)
        {
            var mesaiSonuclari = new List<ShiftResponse>();

            var personelGruplari = mesaiListesi.GroupBy(m => m.Personel).ToList();

            foreach (var grup in personelGruplari)
            {
                DateTime? girisZamani = null;

                foreach (var mesai in grup.OrderBy(m => m.ProcessTime))
                {
                    if (mesai.ProcessStatus)
                    {
                        girisZamani = mesai.ProcessTime;
                    }
                    else if (girisZamani != null)
                    {
                        var vardiya = BulVardiya(girisZamani.Value, mesai.ProcessTime);

                        DateTime vardiyaBaslangici = vardiya.Item1;
                        DateTime vardiyaBitisi = vardiya.Item2;

                        DateTime girisSaati = girisZamani < vardiyaBaslangici ? vardiyaBaslangici : girisZamani.Value;

                        TimeSpan removeTime = TimeSpan.Zero;

                        if (girisSaati.CompareTo(girisZamani) > 0)
                        {
                            removeTime = girisSaati.Subtract(girisZamani.Value);
                        }

                        DateTime cikisSaati = mesai.ProcessTime.CompareTo(vardiyaBitisi) > 1 ? vardiyaBitisi : mesai.ProcessTime;

                        TimeSpan calismaSuresi = mesai.ProcessTime - girisZamani.Value;

                        TimeSpan extraTime = calismaSuresi.Subtract(TimeSpan.FromHours(8)).Subtract(removeTime);

                        // Subtract lunch break time
                        calismaSuresi = calismaSuresi.Subtract(TimeSpan.FromHours(1));

                        // Create new Shift object and add to results
                        mesaiSonuclari.Add(new ShiftResponse()
                        {
                            Name = mesai.Personel,
                            EntryDate = girisZamani.Value.ToString("dd.MM.yyyy HH:mm"),
                            ExitDate = mesai.ProcessTime.ToString("dd.MM.yyyy HH:mm"),
                            MesaiDate = girisZamani.Value.ToString("dd.MM.yyyy"),
                            WorkTime = $"{(int)calismaSuresi.TotalHours:D2}:{calismaSuresi.Minutes:D2}",
                            ExtraWorkTime = $"{(int)extraTime.TotalHours:D2}:{extraTime.Minutes:D2}"
                        });

                        girisZamani = null;
                    }
                }
            }

            return mesaiSonuclari;
        }

        private (DateTime, DateTime) BulVardiya(DateTime girisZamani, DateTime cikisZamani)
        {
            TimeSpan ortalamaZaman = (girisZamani.TimeOfDay + cikisZamani.TimeOfDay) / 2;

            if (ortalamaZaman >= new TimeSpan(8, 0, 0) && ortalamaZaman < new TimeSpan(16, 0, 0))
            {
                return (girisZamani.Date.AddHours(8), girisZamani.Date.AddHours(16));
            }
            else if (ortalamaZaman >= new TimeSpan(16, 0, 0) && ortalamaZaman < new TimeSpan(24, 0, 0))
            {
                return (girisZamani.Date.AddHours(16), girisZamani.Date.AddDays(1).AddHours(0));
            }
            else
            {
                return (girisZamani.Date.AddDays(-1).AddHours(0), girisZamani.Date.AddHours(8));
            }
        }
    }

}
