using NBSoft.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBSoft.Domain.Model.MasterPanel
{
    public class MajorGroupSubject: BaseModel
    {
        [Required]
        [StringLength(150)]
        public string Name { get; set; } //if isFaculty==true then subject name will be Science/Arts/Business
        [StringLength(50)]
        public string code { get; set; }
        [DefaultValue(false)]
        public bool isGroup { get; set; }=false;
    }
}
