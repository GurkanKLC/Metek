using System;

namespace Metek.Application.Dtos.Mesai.Request
{
    public class MesaiDeleteRequest
    {
        public int Id { get; set; }
        public string Personel { get; set; }
        public DateTime ProcessTime { get; set; }
        public bool ProcessStatus { get; set; }
    } 
}
