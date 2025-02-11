﻿using NBSoft.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBSoft.Domain.Model.MasterPanel
{
    [Table("Gender")]
    public class Gender: BaseModel
    {
        [StringLength(120)]
        public string Name { get; set; } //Male,Female,Other
        [StringLength(30)]
        public string shortName { get; set; } //M,F,O
    }
}
