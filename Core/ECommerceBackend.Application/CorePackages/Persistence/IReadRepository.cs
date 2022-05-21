﻿using ECommerceBackend.Application.CorePackages.Persistence.EntityFramework;
using ECommerceBackend.Domain.Entities.Common;
using System.Linq.Expressions;

namespace ECommerceBackend.Application.CorePackages.Persistence
{
    public interface IReadRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        IQueryable<TEntity> GetAll(bool tracking = true);
        IQueryable<TEntity> GetWhere(Expression<Func<TEntity, bool>> predicate, bool tracking = true);
        Task<TEntity> GetSingleAsync(Expression<Func<TEntity, bool>> predicate, bool tracking = true);
        Task<TEntity> GetByIdAsync(string id, bool tracking = true);
    }
}
