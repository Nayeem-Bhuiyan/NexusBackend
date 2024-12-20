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
    [Table("Thana")]
    public class Thana : BaseModel
    {
        [Required]
        [StringLength(150)]
        public string Name { get; set; }
        [StringLength(50)]
        public string code { get; set; }

        [ForeignKey("DistrictId")]
        public int? DistrictId { get; set; }
        public District District { get; set; }
    }
}
