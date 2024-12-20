using NBSoft.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBSoft.Domain.Model.MasterPanel
{
    [Table("SmartModule")]
    public class SmartModule: BaseModel
    {
        public SmartModule()
        {
            this.isActive = false;
        }
        [StringLength(150)]
        public string Name { get; set; }
        [StringLength(150)]
        public string shortName { get; set; } //Area Name
        [DefaultValue(false)]
        public bool isActive { get; set; }
    }
}
