using System;
using System.Collections.Generic;
using System.Text;

namespace Atlas.Application.eCommerce.ComissaoAgencia
{
    public class AgenciaDTO
    {
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string CNPJ { get; set; }
        public decimal Comissao { get; set; }
        public int IdAgencia { get; set; }
    }
}
