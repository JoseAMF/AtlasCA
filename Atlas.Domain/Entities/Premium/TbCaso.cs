using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.Premium
{
    public partial class TbCaso
    {
        public TbCaso()
        {
            TbCasoComunicacao = new HashSet<TbCasoComunicacao>();
            TbCasoMedico = new HashSet<TbCasoMedico>();
            TbCasoViagem = new HashSet<TbCasoViagem>();
        }

        public int IdCaso { get; set; }
        public int IdBeneficiario { get; set; }
        public string TpCaso { get; set; }
        public int? IdMunicipio { get; set; }
        public DateTime DhAbertura { get; set; }
        public DateTime? DhEncerramento { get; set; }
        public string DsUsuaEncerramento { get; set; }
        public string CdStatus { get; set; }
        public string AtAutorizado { get; set; }
        public string DsUsuaInclusao { get; set; }
        public DateTime DhInclusao { get; set; }
        public string DsUsuaAlteracao { get; set; }
        public DateTime DhAlteracao { get; set; }
        public string IdRefContato { get; set; }
        public int? IdCasoRef { get; set; }
        public string IdCobertura { get; set; }
        public string NrVoucher { get; set; }
        public int? IdContato { get; set; }
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
        public int? IdTpContato { get; set; }
        public string CdPais { get; set; }
        public string CdIdioma { get; set; }
        public string TpGop { get; set; }
        public DateTime? DtViagem { get; set; }
        public string AtAcionamentoPrevio { get; set; }

        public virtual TbBeneficiario IdBeneficiarioNavigation { get; set; }
        public virtual ICollection<TbCasoComunicacao> TbCasoComunicacao { get; set; }
        public virtual ICollection<TbCasoMedico> TbCasoMedico { get; set; }
        public virtual ICollection<TbCasoViagem> TbCasoViagem { get; set; }
    }
}
