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
    [Table("CityCorporationCounsil")]
    public class CityCorporationCounsil: BaseModel
    {
        [Required]
        [StringLength(150)]
        public string Name { get; set; }
        public int? counsilNo { get; set; }

        [ForeignKey("CityCorporationId")]
        public int? CityCorporationId { get; set; }
        public CityCorporation CityCorporation { get; set; }
    }
}
