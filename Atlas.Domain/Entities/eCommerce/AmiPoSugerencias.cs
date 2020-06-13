using System;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class AmiPoSugerencias
    {
        public int IdSugerencia { get; set; }
        public string Tipo { get; set; }
        public int? IdDestino { get; set; }
        public string CodiProductoOrigen { get; set; }
        public string CodiProductoResultante { get; set; }
        public DateTime? VigenciaDesde { get; set; }
        public DateTime? VigenciaHasta { get; set; }
        public int? IdAgencia { get; set; }
    }
}
