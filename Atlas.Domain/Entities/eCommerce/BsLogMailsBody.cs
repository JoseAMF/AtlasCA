using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class BsLogMailsBody
    {
        public int IdLogMail { get; set; }
        public string MailBody { get; set; }

        public virtual BsLogMails IdLogMailNavigation { get; set; }
    }
}
