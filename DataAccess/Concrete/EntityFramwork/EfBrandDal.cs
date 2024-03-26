using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace DataAccess.Concrete.EntityFramwork
{
    public class EfBrandDal : IBrandDal
    {
        public void Add(Brand entity)
        {
            using(Context context = new Context()) {
            var addEntity=context.Entry(entity);
                addEntity.State=EntityState.Added;
            }
        }

        public void Delete(Brand entity)
        {
            using (Context context=new Context())
            {
                var deleteEntity=context.Entry(entity);
                deleteEntity.State = EntityState.Deleted;
            }
        }
        public void Update(Brand entity)
        {
            using(Context context=new Context())
            {
                var updateEntity=context.Entry(entity);
                updateEntity.State = EntityState.Modified;
            }
        }

        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            using (Context context = new Context())
            {
                return context.Set<Brand>().SingleOrDefault(filter);
            }
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            using(Context context=new Context())
            {
                return filter==null ? 
                    context.Set<Brand>().ToList() :
                    context.Set<Brand>().Where(filter).ToList();

            }
        }

      
    }
}
