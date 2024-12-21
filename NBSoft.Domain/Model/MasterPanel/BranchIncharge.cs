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
    [Table("BranchIncharge")]
    public class BranchIncharge : BaseModel
    {
        [StringLength(150)]
        public string Name { get; set; }
        [StringLength(50)]
        public string code { get; set; }
        [StringLength(150)]
        public string fatherName { get; set; }
        [StringLength(150)]
        public string motherName { get; set; }
        [StringLength(30)]
        public string contactNumber { get; set; }
        [StringLength(100)]
        public string email { get; set; }
        public string address { get; set; }


        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? fromDate { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? toDate { get; set; }

        [ForeignKey("BranchId")]
        public int BranchId { get; set; }
        public Branch Branch { get; set; }
    }
}
