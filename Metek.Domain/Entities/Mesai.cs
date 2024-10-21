using Metek.Persistence.Repositories;
using System;
using System.Text.Json.Serialization;
namespace Metek.Domain.Entities
{
    public class Mesai:Entity<int>
    {
        public string Personel { get; set; }
        public DateTime ProcessTime { get; set; }
        public bool ProcessStatus { get; set; }
    }
}
