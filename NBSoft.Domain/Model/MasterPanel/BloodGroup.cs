using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NBSoft.Domain.Common;
namespace NBSoft.Domain.Model.MasterPanel
{
    [Table("BloodGroup")]
    public class BloodGroup: BaseModel
    {
        public string Name { get; set; }
    }
}
