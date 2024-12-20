using Microsoft.EntityFrameworkCore.Query;
using NBSoft.Domain.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NBSoft.Application.Interfaces.IRepository
{
    //IBaseRepository
    public interface IBaseRepository<T> where T : class, IEntity
    {
        IQueryable<T> Entities { get; }
        Task<T> GetByIdAsync(int id);
        Task<List<T>> GetAllAsync();
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}
