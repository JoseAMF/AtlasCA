﻿using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.Premium
{
    public partial class TbVoucher
    {
        public string NrVoucher { get; set; }
        public string DsCliente { get; set; }
        public int? IdTpDocumento { get; set; }
        public string NrDocumento { get; set; }
        public string DsEndereco { get; set; }
        public string DsComplemento { get; set; }
        public int IdMunicipio { get; set; }
        public DateTime DtContratacao { get; set; }
        public DateTime? DtValidade { get; set; }
        public string IdProduto { get; set; }
        public string AtAtivo { get; set; }
        public string IdOrdemPagamento { get; set; }
        public decimal? VlVoucher { get; set; }
        public string DsUsuario { get; set; }
        public DateTime DhAlteracao { get; set; }
        public DateTime DtInicioVigencia { get; set; }
        public DateTime? DtCancelamento { get; set; }
        public string DsEmailCliente { get; set; }
        public string NrTelefoneEmergencia { get; set; }
        public string DsContatoEmergencia { get; set; }
        public string DsPathArquivoPdf { get; set; }
        public DateTime? DtInativacao { get; set; }
        public string DsInativacao { get; set; }
    }
}
