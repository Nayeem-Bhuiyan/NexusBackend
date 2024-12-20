using NBSoft.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBSoft.Domain.Entities
{
    public class Country:BaseAuditableEntity
    {
        public string Name { get; set; }
        public string code { get; set; }
        public string mobileDialingCode { get; set; }
        public string flagUrl { get; set; }

    }
}
