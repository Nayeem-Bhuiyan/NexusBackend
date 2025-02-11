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
    [Table("SalaryType")]
    public class SalaryType: BaseModel
    {
        [StringLength(100)]
        public string Name { get; set; } //Consolidated,Regular
        [StringLength(50)]
        public string shortName { get; set; } //Consolidated=C,Regular=R
    }
}
