using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Add(Car car)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Car car)
        {
            throw new NotImplementedException();
        }
        public IResult Update(Car car)
        {
            throw new NotImplementedException();
        }
        public IDataResult<List<Car>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Car> GetAllByBrandId(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Car>> GetByDailyPrice(decimal min, decimal max)
        {
            throw new NotImplementedException();
        }

        public IDataResult<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

       
    }
}
