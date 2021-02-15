﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car(){ Id=1, BrandId=1, ColorId=5, DailyPrice=20, ModelYear= 2000, Description="spor araba" },
                new Car(){ Id=2, BrandId=1, ColorId=4, DailyPrice=30, ModelYear= 1985, Description="nostaljik araba" },
                new Car(){ Id=3, BrandId=2, ColorId=3, DailyPrice=40, ModelYear= 2008, Description="spor araba" },
                new Car(){ Id=4, BrandId=2, ColorId=2, DailyPrice=50, ModelYear= 2010, Description="spor araba" },
                new Car(){ Id=5, BrandId=3, ColorId=1, DailyPrice=60, ModelYear= 2012, Description="sedan" }
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
