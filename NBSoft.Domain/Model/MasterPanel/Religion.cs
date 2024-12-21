using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NBSoft.Domain.Common;

namespace NBSoft.Domain.Model.MasterPanel
{
    [Table("Religion")]
    public class Religion : BaseModel
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; } //Islam,Hindu,Christian,Buddist
    }
}
