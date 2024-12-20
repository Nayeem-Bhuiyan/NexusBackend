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
    [Table("EducationLevel")]
    public class EducationLevel: BaseModel
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(30)]
        public string code { get; set; }
        public ICollection<Education> Educations { get; set; } = new List<Education>();
    }
}
