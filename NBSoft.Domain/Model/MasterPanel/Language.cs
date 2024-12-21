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
    [Table("Language")]
    public class Language: BaseModel
    {
        [StringLength(150)]
        public string Name { get; set; } //Bangla,English
        [StringLength(50)]
        public string shortName { get; set; } //BN,EN
    }
}
