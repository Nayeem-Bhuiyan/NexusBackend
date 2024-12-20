using NBSoft.Domain.Common;
using NBSoft.Domain.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBSoft.Domain.Model.MasterPanel
{
    [Table("Country")]
    public class Country: BaseModel
    {
        [Required]
        [StringLength(150)]
        public string Name { get; set; }
        [StringLength(50)]
        public string code { get; set; }
        [StringLength(50)]
        public string shortName { get; set; }      
        [StringLength(50)]
        public string mobileDialingCode { get; set; } //For BD +880
    }
}
