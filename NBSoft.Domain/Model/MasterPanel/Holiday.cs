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
    [Table("Holiday")]
    public class Holiday: BaseModel
    {
        [Required]
        [StringLength(150)]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime fromDate { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime toDate { get; set; }

        [Required]
        [ForeignKey("AccademicYearId")]
        public int AccademicYearId { get; set; }
        public AccademicYear AccademicYear { get; set; }     
        
        [ForeignKey("HolydayTypeId")]
        public int? HolydayTypeId { get; set; }
        public HolydayType HolydayType { get; set; }


        [ForeignKey("InstitutionalDivisionId")]
        public int? InstitutionalDivisionId { get; set; }
        public InstitutionalDivision InstitutionalDivision { get; set; }
    }
}
