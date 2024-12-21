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
    [Table("Municipality")]
    public class Municipality: BaseModel
    {
        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        [StringLength(50)]
        public string code { get; set; }
        [StringLength(150)]
        public string address { get; set; }

        [ForeignKey("ThanaId")]
        public int? ThanaId { get; set; }
        public Thana Thana { get; set; }
    }
}
