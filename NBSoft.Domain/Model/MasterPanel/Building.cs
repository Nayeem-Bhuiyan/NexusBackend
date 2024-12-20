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
    [Table("Building")]
    public class Building: BaseAuditableEntity
    {

        [StringLength(150)]
        public string Name { get; set; }
        [StringLength(50)]
        public string code { get; set; }
        [StringLength(50)]
        public string buildingPosition { get; set; }
        [StringLength(100)]
        public string buildingType { get; set; } //Accademic,Administrative--etc


        [ForeignKey("BranchId")]
        public int? BranchId { get; set; }
        public Branch Branch { get; set; }

    }
}
