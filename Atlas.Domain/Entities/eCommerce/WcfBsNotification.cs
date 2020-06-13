using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class WcfBsNotification
    {
        public int IdNotification { get; set; }
        public string TriggerName { get; set; }
        public bool? Daily { get; set; }
        public int? DayWeek { get; set; }
        public int? DayMonth { get; set; }
        public TimeSpan? ShippingHours { get; set; }
        public string SMessage { get; set; }
        public string UrlofEmail { get; set; }
        public int? ModuleId { get; set; }
        public string DestinationList { get; set; }
        public string NotificationType { get; set; }
        public string Code { get; set; }
    }
}
