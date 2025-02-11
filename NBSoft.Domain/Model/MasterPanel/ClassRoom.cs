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
    [Table("ClassRoom")]
    public class ClassRoom: BaseModel
    {
        [StringLength(150)]
        public string Name { get; set; }
        [StringLength(150)]
        public string code { get; set; }

        [ForeignKey("BranchId")]
        public int? BranchId { get; set; }
        public Branch Branch { get; set; }

        [ForeignKey("AccademicClassId")]
        public int? AccademicClassId { get; set; }
        public AccademicClass AccademicClass { get; set; }

        [ForeignKey("AccademicSectionId")]
        public int? AccademicSectionId { get; set; }
        public AccademicSection AccademicSection { get; set; } //cascading by AccademicClass

        [ForeignKey("BuildingRoomId")]
        public int? BuildingRoomId { get; set; }
        public BuildingRoom BuildingRoom { get; set; }
    }
}
