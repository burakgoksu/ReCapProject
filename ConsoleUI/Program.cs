using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            //CarManager carManager = new CarManager(new EfCarDal());

            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.Description);
            //}

            //Console.WriteLine("-----------------------------------------------------------");

            //CarManager carManager1 = new CarManager(new EfCarDal());

            //foreach (var car in carManager1.GetCarsByBrandId(2))
            //{
            //    Console.WriteLine(car.Description);
            //}

            //Console.WriteLine("-----------------------------------------------------------");

            //CarManager carManager2 = new CarManager(new EfCarDal());

            //foreach (var car in carManager2.GetCarsByColorId(3))
            //{
            //    Console.WriteLine(car.Description);
            //}

            //Console.WriteLine("-----------------------------------------------------------");

            //CarManager carManager3 = new CarManager(new EfCarDal());

            //carManager3.Add(new Car() { ColorId = 1 , BrandId = 3 , DailyPrice = 100, Description = "opel" , ModelYear = 2010});
            //foreach (var car in carManager3.GetAll())
            //{
            //    Console.WriteLine(car.Description);
            //}



            //Console.WriteLine("-----------------------------------------------------------");

            //ColorManager colorManager = new ColorManager(new EfColorDal());

            //foreach (var color in colorManager.GetAll())
            //{
            //    Console.WriteLine(color.ColorName);
            //}

            //Console.WriteLine("-----------------------------------------------------------");

            //ColorManager colorManager1 = new ColorManager(new EfColorDal());

            //foreach (var color in colorManager1.GetColorById(2))
            //{
            //    Console.WriteLine(color.ColorName);
            //}

            //Console.WriteLine("-----------------------------------------------------------");

            //ColorManager colorManager2 = new ColorManager(new EfColorDal());

            //foreach (var color in colorManager2.GetColorById(2))
            //{
            //    Console.WriteLine(color.ColorName);
            //}

            //colorManager.Add(new Color() { ColorName = "turuncu" });

            //Console.WriteLine("-----------------------------------------------------------");

            //ColorManager colorManager3 = new ColorManager(new EfColorDal());

            //foreach (var color in colorManager3.GetAll())
            //{
            //    Console.WriteLine(color.ColorName);
            //}

            //Console.WriteLine("-----------------------------------------------------------");

            //BrandManager brandManager = new BrandManager(new EfBrandDal());
            //foreach (var brand in brandManager.GetAll())
            //{
            //    Console.WriteLine(brand.BrandName);
            //}

            //Console.WriteLine("-----------------------------------------------------------");

            //BrandManager brandManager1 = new BrandManager(new EfBrandDal());
            //foreach (var brand in brandManager1.GetBrandById(3))
            //{
            //    Console.WriteLine(brand.BrandName);
            //}

            //Console.WriteLine("-----------------------------------------------------------");

            //BrandManager brandManager2 = new BrandManager(new EfBrandDal());
            //brandManager2.Add(new Brand() { BrandName = "Opel" });
            //foreach (var brand in brandManager2.GetAll())
            //{
            //    Console.WriteLine(brand.BrandName);
            //}

            Console.WriteLine("*******************************************************************");
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("*******************************************************************");

            CarManager carManager4 = new CarManager(new EfCarDal());
            foreach (var car in carManager4.GetCarDetails())
            {
                Console.WriteLine(car.BrandName + " / " + car.Description + " / " + car.ColorName + " / " + car.DailyPrice);
            }


        }
    }
}
