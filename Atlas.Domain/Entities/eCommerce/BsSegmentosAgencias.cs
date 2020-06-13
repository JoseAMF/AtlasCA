using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class BsSegmentosAgencias
    {
        public int IdSegmentoAgencia { get; set; }
        public string DescripcionSegmentoAgencia { get; set; }
        public bool? EnviaMensaje { get; set; }
        public string CodigoSegmentoAgencia { get; set; }
    }
}
