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
    [Table("Subject")]
    public class Subject : BaseModel
    {
            [Required]
            [StringLength(150)]
            public string Name { get; set; } 
            [StringLength(50)]
            public string code { get; set; }
            [StringLength(150)]
            public string reportDisplayName { get; set; }
            public int totalMarks { get; set; }
            public int reportSortingOrder { get; set; } = 1;

    }          
    
}
