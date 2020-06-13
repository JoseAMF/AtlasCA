using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class WcfTopic
    {
        public WcfTopic()
        {
            WcfTopicShowCase = new HashSet<WcfTopicShowCase>();
        }

        public int TopicId { get; set; }
        public string TopicCode { get; set; }
        public string Description { get; set; }
        public string CreatedByUserId { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public string LastModifiedByUserId { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }
        public DateTime? DeletedOnDate { get; set; }

        public virtual ICollection<WcfTopicShowCase> WcfTopicShowCase { get; set; }
    }
}
