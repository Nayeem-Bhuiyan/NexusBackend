using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NBSoft.Domain.Common;
namespace NBSoft.Domain.Model.MasterPanel
{
    [Table("BankType")]
    public class BankType: BaseModel
    {
        public string Name { get; set; } //Mobile,Online,Bank
    }


}
