using Business.Concrete;
using DataAccess.Concrete.EntityFramwork;
using DataAccess.Concrete.InMemoryDal;
using System;
using System.Text.Json.Serialization;



CarManager carManager=new CarManager(new EfCarDal());

foreach (var car in carManager.GetAll())
{
    Console.WriteLine(car.Description); 
}
