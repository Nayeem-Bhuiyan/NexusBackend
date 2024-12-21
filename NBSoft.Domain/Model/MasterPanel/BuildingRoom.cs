using NBSoft.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBSoft.Domain.Model.MasterPanel
{
    [Table("BuildingRoom")]
    public class BuildingRoom: BaseAuditableEntity
    {
        public string Name { get; set; } //Name==roomNumber duplicate should be control by Building
        public int? floorNumber { get; set; }
        public string roomNumber { get; set; }    

        [ForeignKey("BuildingId")]
        public int BuildingId { get; set; }
        public Building Building { get; set; }
    }
}
