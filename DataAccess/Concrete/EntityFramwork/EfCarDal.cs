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
using Entities.DTOs;
namespace DataAccess.Concrete.EntityFramwork
{
    public class EfCarDal : EfEntityRepositoryBase<Car, Context>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (Context context= new Context())
            {
                var result = from car in context.Cars
                             join col in context.Colors
                             on car.ColorId equals col.Id
                             select new CarDetailDto
                             {
                                 CarName = car.Name,
                                 CarId = car.Id,
                                 ColorName = col.Name,
                                 DailyPrice = car.DailyPrice
                             };
                return result.ToList();
            }
        }

        public List<Car> Ozelbirmethod() //özel methodlaar için ICarDal'ıda yazarız
        {
            throw new NotImplementedException();
        }
    }
}
