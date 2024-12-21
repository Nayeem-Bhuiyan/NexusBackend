using NBSoft.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBSoft.Domain.Model.MasterPanel
{
    [Table("Currency")]
    public class Currency : BaseModel
    {
        [StringLength(150)]
        public string Name { get; set; }
        [StringLength(120)]
        public string symbolText { get; set; }
        [StringLength(120)]
        public string symbolSign { get; set; }

        public int? decimalAllow { get; set; }
    }
}
