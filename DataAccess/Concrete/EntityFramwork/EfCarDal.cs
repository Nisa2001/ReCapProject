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
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            using(Context context=new Context())
            {
                var addEntity=context.Entry(entity);
                addEntity.State=EntityState.Added;
            }
        }

        public void Delete(Car entity)
        {
            using(Context context=new Context())
            {
                var deleteEntity=context.Entry(entity);
                deleteEntity.State=EntityState.Deleted;
            }
        }
        public void Update(Car entity)
        {
           using(Context context=new Context())
            {
                var updateEntity = context.Entry(entity);
                updateEntity.State=EntityState.Modified;
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (Context context = new Context())
            {
                return context.Set<Car>().SingleOrDefault(filter);
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
           using(Context context = new Context())
            {
                return filter==null ?
                    context.Set<Car>().ToList() :
                    context.Set<Car>().Where(filter).ToList();
            }
        }

       
    }
}
