using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using NBSoft.Domain.Common;
namespace NBSoft.Domain.Model.MasterPanel
{
    [Table("BankBranch")]
    public class BankBranch: BaseModel
    {
        [StringLength(120)]
        public string Name { get; set; }
        [StringLength(250)]
        public string address { get; set; }
        public bool isMainBranch { get; set; }
        [StringLength(30)]
        public string contact { get; set; }
        [StringLength(120)]
        public string email { get; set; }

        //ForeignKey
        [ForeignKey("BankId")]
        public int BankId { get; set; }
        public Bank Bank { get; set; }

        [ForeignKey("BranchId")]
        public int? BranchId { get; set; }
        public Branch Branch { get; set; }
    }
}
