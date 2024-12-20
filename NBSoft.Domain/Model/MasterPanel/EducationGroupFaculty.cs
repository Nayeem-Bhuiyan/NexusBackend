using NBSoft.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBSoft.Domain.Model.MasterPanel
{
    [Table("EducationGroupFaculty")]
    public class EducationGroupFaculty: BaseModel
    {
        public EducationGroupFaculty()
        {
            this.GroupOrFacultyType="GF";
        }
        public string Name { get; set; }//Science,Business,Arts,Social Science,
        public string GroupOrFacultyType { get; set; } //Html Dropdown option:  GF=Group and Faculty,G=Group,F=Faculty
    }
}
