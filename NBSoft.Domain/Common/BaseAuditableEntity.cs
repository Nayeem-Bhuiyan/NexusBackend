using NBSoft.Domain.Common.Interfaces;

namespace NBSoft.Domain.Common
{
    public abstract class BaseAuditableEntity : BaseEntity, IAuditableEntity
    {
          public int? createdBy { get; set; }
          public DateTime? createdDate { get; set; }
          public int? updatedBy { get; set; }
          public DateTime? updatedDate { get; set; }
          public int? deletedBy { get; set; }
          public bool? isDeleted { get; set; }
          public DateTime? deletedDate { get; set; }
    }
}
