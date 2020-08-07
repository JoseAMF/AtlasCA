using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.Premium
{
    public partial class TbCasoLimiteD
    {
        public int IdCaso { get; set; }
        public int IdTipoLimite { get; set; }
        public double VlLimite { get; set; }
        public double VlLimiteComplemetar { get; set; }
        public double VlAutorizado { get; set; }
        public double VlDisponivel { get; set; }
        public int QtLimite { get; set; }
        public int QtLimiteComplementar { get; set; }
        public string DsUsuaInclusao { get; set; }
        public DateTime DhInclusao { get; set; }
        public string DsUsuaAlteracao { get; set; }
        public DateTime DhAlteracao { get; set; }
    }
}
