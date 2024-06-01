using FirstNTierArchitectureProject.DataAccess.Abstract;
using FirstNTierArchitectureProject.DataAccess.Concrete.Context;
using FirstNTierArchitectureProject.Entity.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FirstNTierArchitectureProject.DataAccess.Concrete.EntityFramework;
public class EfEntityRepositoryDal<TEntity, TContext> : IEntityDal<TEntity>
    where TEntity : class, IEntity, new()
    where TContext : DbContext, new()
{
    public void Add(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public TEntity Get(Expression<Func<TEntity, bool>> filter)
    {
        throw new NotImplementedException();
    }

    public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
    {
        throw new NotImplementedException();
    }

    public void Update(TEntity entity)
    {
        throw new NotImplementedException();
    }
}
