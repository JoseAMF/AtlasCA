using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.Premium
{
    public partial class TbAuxiliarCargaMovimento
    {
        public int Id { get; set; }
        public int IdProducto { get; set; }
        public DateTime FechaDesde { get; set; }
        public int Dias { get; set; }
        public decimal Importe { get; set; }
        public DateTime DhInclusao { get; set; }
        public string DvBagagemEspecial { get; set; }
        public string DvCompraProtegida { get; set; }
        public string DvCancelamento { get; set; }
    }
}
