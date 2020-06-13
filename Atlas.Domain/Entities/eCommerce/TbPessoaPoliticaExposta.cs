using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class TbPessoaPoliticaExposta
    {
        public int IdPessoaPoliticaExposta { get; set; }
        public int IdVoucher { get; set; }
        public int IdBeneficiario { get; set; }
        public int RelationshipId { get; set; }
    }
}
