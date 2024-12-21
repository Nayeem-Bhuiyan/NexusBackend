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
    [Table("SmartFeature")]
    public class SmartFeature : BaseModel
    {
        [StringLength(150)]
        public string Name { get; set; }
        [StringLength(150)]
        public string areaName { get; set; }
        [StringLength(250)]
        public string controllerName { get; set; }
        [StringLength(150)]
        public string actionName { get; set; }
        [StringLength(150)]
        public string featureUrl => ("~/"+areaName+"/"+controllerName+"/"+actionName);


        [ForeignKey("FeatureCategoryId")]
        public int? FeatureCategoryId { get; set; }
        public FeatureCategory FeatureCategory { get; set; } 
        
        [ForeignKey("SmartModuleId")]
        public int? SmartModuleId { get; set; }
        public SmartModule SmartModule { get; set; }
    }
}
