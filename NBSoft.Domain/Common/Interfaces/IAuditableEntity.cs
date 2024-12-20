namespace NBSoft.Domain.Common.Interfaces
{
    public interface IAuditableEntity : IEntity
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
