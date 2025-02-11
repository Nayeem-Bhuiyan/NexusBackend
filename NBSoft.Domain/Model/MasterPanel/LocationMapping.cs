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
    [Table("LocationMapping")]
    public class LocationMapping: BaseModel
    {
        [Required]
        [StringLength(100)]
        public string mappingAreaName { get; set; } //Citycoporation=C,Municipality=M,Union=U 
    }
}
