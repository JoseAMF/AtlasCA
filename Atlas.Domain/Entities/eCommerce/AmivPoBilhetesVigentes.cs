using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class AmivPoBilhetesVigentes
    {
        public string NúmeroDoBilhete { get; set; }
        public DateTime DataDeEmissão { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public DateTime VigenciaInicial { get; set; }
        public DateTime VigenciaFinal { get; set; }
    }
}
