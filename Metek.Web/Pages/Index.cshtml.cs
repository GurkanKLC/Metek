using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Metek.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IHttpClientFactory _httpClientFactory;

        public IndexModel(ILogger<IndexModel> logger, IHttpClientFactory httpClientFactory)
        {
            _logger = logger;
            _httpClientFactory = httpClientFactory; // IHttpClientFactory'yi kullan
        }

        public void OnGet()
        {
        }

        public async Task<JsonResult> OnGetGetMesaiData()
        {
            var client = _httpClientFactory.CreateClient(); // HttpClient oluştur
            var response = await client.GetStringAsync("https://localhost:44309/WeatherForecast/GetList");
            var logs = JsonConvert.DeserializeObject<List<Mesai>>(response);

            var results = CalculateOvertime(logs);
            return new JsonResult(results);
        }

        private List<MesaiResult> CalculateOvertime(List<Mesai> logs)
        {
            var results = new List<MesaiResult>();

            for (int i = 0; i < logs.Count; i++)
            {
                if (logs[i].ProcessStatus) // Giriş
                {
                    var entryLog = logs[i];
                    if (i + 1 < logs.Count && !logs[i + 1].ProcessStatus) // Sonraki çıkış
                    {
                        var exitLog = logs[i + 1];

                        TimeSpan workingTime = exitLog.ProcessTime - entryLog.ProcessTime;
                        TimeSpan overtime = CalculateOvertime(entryLog.ProcessTime, exitLog.ProcessTime);

                        results.Add(new MesaiResult
                        {
                            Personel = entryLog.Personel,
                            EntryTime = entryLog.ProcessTime,
                            ExitTime = exitLog.ProcessTime,
                            WorkingTime = workingTime,
                            Overtime = overtime
                        });
                    }
                }
            }
            return results;
        }

        private TimeSpan CalculateOvertime(DateTime entryTime, DateTime exitTime)
        {
            TimeSpan shiftEnd = new TimeSpan(17, 0, 0); // 17:00

            if (exitTime.TimeOfDay > shiftEnd)
            {
                return exitTime.TimeOfDay - shiftEnd;
            }
            return TimeSpan.Zero;
        }
    }

    public class Mesai
    {
        public int MesaiId { get; set; }
        public string Personel { get; set; }
        public DateTime ProcessTime { get; set; }
        public bool ProcessStatus { get; set; }
    }

    public class MesaiResult
    {
        public string Personel { get; set; }
        public DateTime EntryTime { get; set; }
        public DateTime ExitTime { get; set; }
        public TimeSpan WorkingTime { get; set; }
        public TimeSpan Overtime { get; set; }
    }
}
