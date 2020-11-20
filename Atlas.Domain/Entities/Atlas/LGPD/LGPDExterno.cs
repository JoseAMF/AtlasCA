using Atlas.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Atlas.Domain.Entities.Atlas.LGPD
{
    public class LGPDExterno : AuditableEntity
    {
        public int Id { get; set; }
        public string CodigoGrupo { get; set; }
        public string CodigoUsuario { get; set; }
        public string DescricaoGrupo { get; set; }
        public DateTime DataGrupoCriacao { get; set; }
        public DateTime DataCriacao { get; set; }
        public string URL { get; set; }
        public string DescricaoTela { get; set; }
        public DateTime DataUsuarioPermissao { get; set; }
        public string TipoAcesso { get; set; } // RO -> Leitura | RW -> Escrita

    }
}
