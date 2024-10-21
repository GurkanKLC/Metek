using System;
using System.Collections.Generic;
using System.Text;

namespace Metek.Application.Dtos.Mesai.Response
{
    public class ShiftResponse
    {
        public string Name { get; set; }
        public string MesaiDate { get; set; }
        public string EntryDate { get; set; }
        public string ExitDate { get; set; }
        public string WorkTime { get; set; }
        public string ExtraWorkTime { get; set; }
    }


}
