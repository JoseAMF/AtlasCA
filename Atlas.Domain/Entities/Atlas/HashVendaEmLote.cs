using System;
namespace Atlas.Domain.Entities.Atlas
{
    public class HashVendaEmLote
    {
        public int id { get; set; }
        public string Hash { get; set; }
        public DateTime dh_inclusao { get; set; }
        public string Ambiente { get; set; }
        public User User { get; set; }
    }
}