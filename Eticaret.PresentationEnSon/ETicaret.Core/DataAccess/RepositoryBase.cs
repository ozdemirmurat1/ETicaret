using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret.Core.DataAccess
{
    public class RepositoryBase<TTablo,TContext> : IRepository<TTablo> 
        where TTablo:class,IEntity,new()
        where TContext:DbContext,new()

    {
        public void Add(TTablo entity)
        {
            using (var context = new TContext())
            {
                var add = context.Entry(entity);
                add.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public bool Any(Expression<Func<TTablo, bool>> filter)
        {
            using (var context = new TContext())
            {
                return context.Set<TTablo>().Any(filter);
            }
        }

        public void Delete(TTablo entity)
        {
            using (var context = new TContext())
            {
                var delete = context.Entry(entity);
                delete.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TTablo Get(Expression<Func<TTablo, bool>> filter)
        {
            using (var context = new TContext())
            {
                return context.Set<TTablo>().FirstOrDefault(filter);
            }
        }

        public List<TTablo> List(Expression<Func<TTablo, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return filter == null
                    ? context.Set<TTablo>().ToList()
                    : context.Set<TTablo>().Where(filter).ToList();
            }
        }

        public IQueryable<TTablo> Query(Expression<Func<TTablo, bool>> filter)
        {
            var context = new TContext();

            return context.Set<TTablo>().Where(filter).AsQueryable();


        }

        public void Update(TTablo entity)
        {
            using (var context = new TContext())
            {
                var update = context.Entry(entity);
                update.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
