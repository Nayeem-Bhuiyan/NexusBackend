using NBSoft.Domain.Common;
using NBSoft.Domain.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBSoft.Domain.Model.MasterPanel
{
    [Table("AccademicClass")]
    public class AccademicClass: BaseModel
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; } //One,Two,Three---
    }
}
