using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NBSoft.Domain.Common;

namespace NBSoft.Domain.Model.MasterPanel
{
    [Table("AddressType")]
    public class AddressType: BaseModel
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; } //Present,Permanent
    }
}
