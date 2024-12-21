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
    [Table("Education")]
    public class Education: BaseModel
    {
        public Education() {
            this.SortingOrder=1;
        }
        
        [Required]
        [StringLength(120)]
        public string Name { get; set; } //S.S.C/H.S.C/B.S.C
        [StringLength(30)]
        public string code { get; set; }

        [StringLength(30)]
        public string ExamController { get; set; }  //Dropdown :Board,University

        public int SortingOrder { get; set; }

        [ForeignKey("EducationLevelId")]
        public int? EducationLevelId { get; set; }
        public EducationLevel EducationLevel { get; set; }
        //public ICollection<EmpEducation> EmpEducations { get; set; } = new List<EmpEducation>();
    }
}
