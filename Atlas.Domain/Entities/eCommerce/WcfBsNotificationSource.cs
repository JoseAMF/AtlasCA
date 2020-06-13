using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class WcfBsNotificationSource
    {
        public int IdNotificationSource { get; set; }
        public int IdNotification { get; set; }
        public string Source { get; set; }
        public string TableName { get; set; }
        public string FieldFather { get; set; }
        public string FieldSon { get; set; }
        public int OrderNumber { get; set; }
    }
}
