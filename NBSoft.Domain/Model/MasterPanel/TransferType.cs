using NBSoft.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBSoft.Domain.Model.MasterPanel
{
    [Table("TransferType")]
    public class TransferType: BaseModel
    {
        public string Name { get; set; } //Branch,Department,Section etc
    }
}
