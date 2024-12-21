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
    [Table("GradeScale")]
    public class GradeScale: BaseAuditableEntity
    {
        [StringLength(150)]
        public string Name { get; set; }
        public decimal basicSalary { get; set; }
        public decimal maximumBasicSalary { get; set; }
        public decimal probitionSalary { get; set; }
    }
}
