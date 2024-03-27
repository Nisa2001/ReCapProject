using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Core.DataAccess.EntityFramework;
namespace DataAccess.Concrete.EntityFramwork
{
    public class EfColorDal : EfEntityRepositoryBase<Color, Context>, IColorDal
    {
        //public void Add(Color entity)
        //{
        //    using (Context context = new Context())
        //    {
        //      var  addEntity=context.Entry(entity);
        //        addEntity.State = EntityState.Added;
        //        context.SaveChanges();
        //    }
        //}  
    }
}
