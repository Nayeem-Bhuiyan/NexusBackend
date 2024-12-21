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
    [Table("District")]
    public class District : BaseModel
    {
        [Required]
        public string Name { get; set; }
        [StringLength(50)]
        public string code { get; set; }

        [ForeignKey("DivisionId")]
        public int? DivisionId { get; set; }
        public Division Division { get; set; }
    }
}
