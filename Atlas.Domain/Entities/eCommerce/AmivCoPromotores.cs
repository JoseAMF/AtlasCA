using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class AmivCoPromotores
    {
        public int Idvendedor { get; set; }
        public string Legajo { get; set; }
        public string Apevendedor { get; set; }
        public string Nombrevendedor { get; set; }
        public string Supervisor { get; set; }
        public string Descripciontipodocumento { get; set; }
        public string Numerodocumento { get; set; }
        public string Genero { get; set; }
        public DateTime? Fecnacimiento { get; set; }
        public int Idagencia { get; set; }
        public string Denominacionagencia { get; set; }
        public int Iduser { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
