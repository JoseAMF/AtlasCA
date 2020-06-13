using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class T
    {
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public int? Chksum { get; set; }
    }
}
