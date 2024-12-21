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
    [Table("QoutaInfo")]
    public class QoutaInfo: BaseModel
    {
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(20)]
        public string code { get; set; }
    }
}
