using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class WcfQtDiasMultiviagem
    {
        public int QtDiasMultiViagemId { get; set; }
        public int QtDiasMultiViagem { get; set; }
        public bool? Default { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
    }
}
