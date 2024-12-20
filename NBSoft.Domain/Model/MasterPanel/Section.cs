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
    [Table("Section")]
    public class Section: BaseModel  //this table is not for student data (AccademicSection for student)
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(30)]
        public string code { get; set; }

        [ForeignKey("DepartmentId")]
        public int? DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
