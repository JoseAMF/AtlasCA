using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class WcfWebUsers
    {
        public int WebUserId { get; set; }
        public string Document { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string EmailAlternative { get; set; }
        public int? AddressId { get; set; }
        public string PhoneCode { get; set; }
        public string PhoneNumber { get; set; }
        public string CellularCode { get; set; }
        public string CellularNumber { get; set; }
        public string Password { get; set; }
        public DateTime? DateCreated { get; set; }
        public string FacebookId { get; set; }
        public string GoogleId { get; set; }
    }
}
