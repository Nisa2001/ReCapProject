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
    public class EfColorDal : IColorDal
    {
        public void Add(Color entity)
        {
            using (Context context = new Context())
            {
              var  addEntity=context.Entry(entity);
                addEntity.State = EntityState.Added;
            }
        }

        public void Delete(Color entity)
        {
           using(Context context = new Context())
            {
                var deleteEntity=context.Entry(entity);
                deleteEntity.State = EntityState.Deleted;
            }
        }
        public void Update(Color entity)
        {
           using(Context context =new Context())
            {
                var updateEntity = context.Entry(entity);
                updateEntity.State=EntityState.Modified;
            }
        }

        public Color Get(Expression<Func<Color, bool>> filter)
        {
            using(Context context=new Context())
            {
                return context.Set<Color>().SingleOrDefault(filter);
            }
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
           using (Context context = new Context())
            {
                return filter==null ?
                    context.Set<Color>().ToList() :
                    context.Set<Color>().Where(filter).ToList();
            }
        }

       
    }
}
