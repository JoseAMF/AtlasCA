using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.Premium
{
    public partial class TbPrestador
    {
        public int IdPrestador { get; set; }
        public string DsPrestador { get; set; }
        public string DsContato { get; set; }
        public int IdTpDocumento { get; set; }
        public string NrDocumento { get; set; }
        public string DsEndereco { get; set; }
        public string DsComplemento { get; set; }
        public string DsBairro { get; set; }
        public int IdMunicipio { get; set; }
        public string NrCep { get; set; }
        public string NrTelefone { get; set; }
        public string NrFax { get; set; }
        public string DsEmail { get; set; }
        public string DsObservacao { get; set; }
        public string AtAtivo { get; set; }
        public string DsUsuario { get; set; }
        public DateTime DhAlteracao { get; set; }
    }
}
