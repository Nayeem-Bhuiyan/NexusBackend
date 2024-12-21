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
    [Table("Word")]
    public class Word: BaseModel
    {
        [Required]
        [StringLength(150)]
        public string Name { get; set; }
        public int? wordNo { get; set; }

        [ForeignKey("UnionId")]
        public int? UnionId { get; set; }
        public Union Union { get; set; }
    }
}
