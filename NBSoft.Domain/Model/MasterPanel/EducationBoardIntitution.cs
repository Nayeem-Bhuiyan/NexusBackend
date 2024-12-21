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
    [Table("EducationBoardIntitution")]
    public class EducationBoardIntitution: BaseModel
    {
        [StringLength(150)]
        public string Name { get; set; } //Dhaka,Comilla,Jagannath University etc
        [StringLength(150)]
        public string typeName { get; set; } //Board=B/Intitution=T
    }
}
