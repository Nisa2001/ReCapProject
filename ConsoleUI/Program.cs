﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramwork;
using DataAccess.Concrete.InMemoryDal;
using System;
using System.Text.Json.Serialization;

//Entities, DataAccess, Business ve Console katmanlarını oluşturunuz. +

//Bir araba nesnesi oluşturunuz. "Car"

//Özellik olarak : Id, BrandId, ColorId, ModelYear, DailyPrice, Description alanlarını ekleyiniz. (Brand = Marka) +

//InMemory formatta GetById, GetAll, Add, Update, Delete oprasyonlarını yazınız.

//Consolda test ediniz.

CarManager carManager=new CarManager(new EfCarDal());

foreach (var car in carManager.GetAll())
{
    Console.WriteLine(car.Description); 
}
