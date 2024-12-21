using NBSoft.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBSoft.Domain.Model.MasterPanel
{
    [Table("GradeScaleDetails")]
    public class GradeScaleDetails : BaseModel
    {

        [ForeignKey("GradeScaleId")]
        public int? GradeScaleId { get; set; }
        public GradeScale GradeScale { get; set; }

    }
}
