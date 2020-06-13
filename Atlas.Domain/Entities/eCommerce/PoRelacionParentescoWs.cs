using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PoRelacionParentescoWs
    {
        public int IdParentescoWs { get; set; }
        public int IdParentesco { get; set; }
        public int CodigoParentescoWs { get; set; }

        public virtual PoParentesco IdParentescoNavigation { get; set; }
    }
}
