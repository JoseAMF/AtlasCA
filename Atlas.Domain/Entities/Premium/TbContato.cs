using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.Premium
{
    public partial class TbContato
    {
        public int IdContato { get; set; }
        public string CdPais { get; set; }
        public string DsContato { get; set; }
        public string DsEmail { get; set; }
        public string NrDdiTelefone { get; set; }
        public string NrDddTelefone { get; set; }
        public string NrPrefixoTelefone { get; set; }
        public string NrSufixoTelefone { get; set; }
        public string NrDdiFax { get; set; }
        public string NrDddFax { get; set; }
        public string NrPrefixoFax { get; set; }
        public string NrSufixoFax { get; set; }
        public string DsCaracteristica { get; set; }
        public string DsUsuaInclusao { get; set; }
        public DateTime DhInclusao { get; set; }
        public string DsUsuaAlteracao { get; set; }
        public DateTime DhAlteracao { get; set; }
        public int? IdTpContato { get; set; }
    }
}
