using System;
using System.Collections.Generic;
using System.Text;

namespace Metek.Application.Dtos.Mesai.Request
{
    public class MesaiAddRequest
    {
        public string Personel { get; set; }
        public DateTime ProcessTime { get; set; }
        public bool ProcessStatus { get; set; }
    }    
}
