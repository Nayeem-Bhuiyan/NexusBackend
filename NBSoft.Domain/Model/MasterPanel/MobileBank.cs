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
    [Table("MobileBank")]
    public class MobileBank: BaseAuditableEntity
    {
        [StringLength(150)]
        public string Name { get; set; }
        [StringLength(100)]
        public string shortName { get; set; }  
        
        [StringLength(100)]
        public string code { get; set; }
    }
}
