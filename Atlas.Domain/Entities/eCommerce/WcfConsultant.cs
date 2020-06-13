using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class WcfConsultant
    {
        public int ConsultantId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int? UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public string CreationBy { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
