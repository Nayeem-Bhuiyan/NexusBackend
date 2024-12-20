using NBSoft.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBSoft.Application.Interfaces.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IBaseRepository<T> Repository_BaseAuditableEntity<T>() where T : BaseAuditableEntity;
        IBaseRepository<T> Repository<T>() where T : BaseModel;

        Task<int> Save(CancellationToken cancellationToken);

        Task<int> SaveAndRemoveCache(CancellationToken cancellationToken, params string[] cacheKeys);

        Task Rollback();
    }
}
