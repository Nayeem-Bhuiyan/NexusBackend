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
    [Table("Designation")]
    public class Designation : BaseAuditableEntity
    {

        [Required]
        [StringLength(120)]
        public string Name { get; set; }
        [StringLength(50)]
        public string code { get; set; }
        [StringLength(50)]
        public string shortName { get; set; }

        [ForeignKey("DepartmentId")]
        public int? DepartmentId { get; set; }
        public Department Department { get; set; }

    }
}
