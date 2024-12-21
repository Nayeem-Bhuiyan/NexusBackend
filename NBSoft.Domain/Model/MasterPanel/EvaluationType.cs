using NBSoft.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBSoft.Domain.Model.MasterPanel
{
    [Table("EvaluationType")]
    public class EvaluationType: BaseModel
    {
        public string Name { get; set; } //Promotion,Demotion,Increment,Decrement
        public string code { get; set; } //Promotion,Demotion,Increment,Decrement
    }
}
