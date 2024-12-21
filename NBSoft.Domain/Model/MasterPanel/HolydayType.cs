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
    [Table("HolydayType")]
    public class HolydayType: BaseModel
    {
        [StringLength(150)]
        public string Name { get; set; } //Govt,Eid,Puza,Weekly,Others
    }
}
