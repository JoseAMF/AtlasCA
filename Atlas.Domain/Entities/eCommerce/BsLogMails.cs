using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class BsLogMails
    {
        public int IdLogMail { get; set; }
        public string MailFrom { get; set; }
        public string MailTo { get; set; }
        public string MailBcc { get; set; }
        public string MailSubject { get; set; }
        public string MailBody { get; set; }
        public string MailAttach { get; set; }
        public string MailBodyType { get; set; }
        public string MailResult { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }

        public virtual BsLogMailsBody BsLogMailsBody { get; set; }
    }
}
