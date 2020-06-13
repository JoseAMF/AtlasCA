using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class TbParentescoPpe1
    {
        public TbParentescoPpe1()
        {
            TbPessoaPoliticaExposta1 = new HashSet<TbPessoaPoliticaExposta1>();
        }

        public int IdParentescoPpe { get; set; }
        public string NmParentescoPpe { get; set; }
        public string DsUsuaIncl { get; set; }
        public DateTime DhInclusao { get; set; }
        public string DsUsuaAlte { get; set; }
        public DateTime DhAlteracao { get; set; }

        public virtual ICollection<TbPessoaPoliticaExposta1> TbPessoaPoliticaExposta1 { get; set; }
    }
}
