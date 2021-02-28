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

        //    //CarManager carManager = new CarManager(new EfCarDal());

        //    //foreach (var car in carManager.GetAll())
        //    //{
        //    //    Console.WriteLine(car.Description);
        //    //}

        //    //Console.WriteLine("-----------------------------------------------------------");

        //    //CarManager carManager1 = new CarManager(new EfCarDal());

        //    //foreach (var car in carManager1.GetCarsByBrandId(2))
        //    //{
        //    //    Console.WriteLine(car.Description);
        //    //}

        //    //Console.WriteLine("-----------------------------------------------------------");

        //    //CarManager carManager2 = new CarManager(new EfCarDal());

        //    //foreach (var car in carManager2.GetCarsByColorId(3))
        //    //{
        //    //    Console.WriteLine(car.Description);
        //    //}

        //    //Console.WriteLine("-----------------------------------------------------------");

        //    //CarManager carManager3 = new CarManager(new EfCarDal());

        //    //carManager3.Add(new Car() { ColorId = 1 , BrandId = 3 , DailyPrice = 100, Description = "opel" , ModelYear = 2010});
        //    //foreach (var car in carManager3.GetAll())
        //    //{
        //    //    Console.WriteLine(car.Description);
        //    //}



        //    //Console.WriteLine("-----------------------------------------------------------");

        //    //ColorManager colorManager = new ColorManager(new EfColorDal());

        //    //foreach (var color in colorManager.GetAll())
        //    //{
        //    //    Console.WriteLine(color.ColorName);
        //    //}

        //    //Console.WriteLine("-----------------------------------------------------------");

        //    //ColorManager colorManager1 = new ColorManager(new EfColorDal());

        //    //foreach (var color in colorManager1.GetColorById(2))
        //    //{
        //    //    Console.WriteLine(color.ColorName);
        //    //}

        //    //Console.WriteLine("-----------------------------------------------------------");

        //    //ColorManager colorManager2 = new ColorManager(new EfColorDal());

        //    //foreach (var color in colorManager2.GetColorById(2))
        //    //{
        //    //    Console.WriteLine(color.ColorName);
        //    //}

        //    //colorManager.Add(new Color() { ColorName = "turuncu" });

        //    //Console.WriteLine("-----------------------------------------------------------");

        //    //ColorManager colorManager3 = new ColorManager(new EfColorDal());

        //    //foreach (var color in colorManager3.GetAll())
        //    //{
        //    //    Console.WriteLine(color.ColorName);
        //    //}

        //    //Console.WriteLine("-----------------------------------------------------------");

        //    //BrandManager brandManager = new BrandManager(new EfBrandDal());
        //    //foreach (var brand in brandManager.GetAll())
        //    //{
        //    //    Console.WriteLine(brand.BrandName);
        //    //}

        //    //Console.WriteLine("-----------------------------------------------------------");

        //    //BrandManager brandManager1 = new BrandManager(new EfBrandDal());
        //    //foreach (var brand in brandManager1.GetBrandById(3))
        //    //{
        //    //    Console.WriteLine(brand.BrandName);
        //    //}

        //    //Console.WriteLine("-----------------------------------------------------------");

        //    //BrandManager brandManager2 = new BrandManager(new EfBrandDal());
        //    //brandManager2.Add(new Brand() { BrandName = "Opel" });
        //    //foreach (var brand in brandManager2.GetAll())
        //    //{
        //    //    Console.WriteLine(brand.BrandName);
        //    //}

        //    //Console.WriteLine("*******************************************************************");
        //    //Console.WriteLine("*******************************************************************");
        //    //Console.WriteLine("*******************************************************************");

        //    //CarManager carManager4 = new CarManager(new EfCarDal());
        //    //foreach (var car in carManager4.GetCarDetails())
        //    //{
        //    //    Console.WriteLine(car.BrandName + " / " + car.Description + " / " + car.ColorName + " / " + car.DailyPrice);
        //    //}


        //    CarManager carManager = new CarManager(new EfCarDal());
        //    var result = carManager.GetCarDetails();
        //    if (result.Success)
        //    {
        //        foreach (var car in result.Data)
        //        {
        //            Console.WriteLine(car.BrandName + " / " + car.Description + " / " + car.ColorName + " / " + car.DailyPrice);
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine(result.Message);
        //    }

        //    Console.WriteLine("*******************************************************************");

        //    CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
        //    var result1 = customerManager.GetAll();
        //    if (result1.Success)
        //    {
        //        foreach (var customer in result1.Data)
        //        {
        //            Console.WriteLine(customer.CustomerName);
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine(result1.Message);
        //    }


        //    Console.WriteLine("*******************************************************************");

        //    var result2 = customerManager.GetCustomerById(2);
        //    if (result2.Success)
        //    {
        //        Console.WriteLine(result2.Data.CustomerName);
        //    }
        //    else
        //    {
        //        Console.WriteLine(result2.Message);
        //    }

        //    Console.WriteLine("*******************************************************************");

        //    // customerManager.Add(new Customer { CustomerName = "Volkan", UserId = 2 });

        //    Console.WriteLine("*******************************************************************");

        //    UserManager userManager = new UserManager(new EfUserDal());

        //    var result3 = userManager.GetAll();
        //    if (result3.Success)
        //    {
        //        foreach (var user in result3.Data)
        //        {
        //            Console.WriteLine(user.FirstName + " " + user.LastName + " / " + user.Email + " / " + user.Password);
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine(result3.Message);
        //    }

        //    Console.WriteLine("*******************************************************************");

        //    var result4 = userManager.GetUserById(3);
        //    if (result4.Success)
        //    {
        //        Console.WriteLine(result4.Data.FirstName);
        //    }
        //    else
        //    {
        //        Console.WriteLine(result4.Message);
        //    }

        //    Console.WriteLine("*******************************************************************");

        //    // userManager.Add(new User { FirstName = "Kerem", LastName = "Varış", Email = "keremvaris@gmail.com", Password = "abcd123456" });

        //    Console.WriteLine("*******************************************************************");

        //    RentalManager rentalManager = new RentalManager(new EfRentalDal());
        //    var result5 = rentalManager.GetAll();
        //    if (result5.Success)
        //    {
        //        foreach (var rental in result5.Data)
        //        {
        //            Console.WriteLine("Customer Id : " + rental.CustomerId + " / " + "Car Id : " + rental.CarId + " / " + "Rental Id : " + rental.RentalId + " / " + "Rental Date : " + rental.RentDate + " / " + "Rental Return : " + rental.RentDate);
        //        }

        //    }
        //    else
        //    {
        //        Console.WriteLine(result5.Message);
        //    }

        //    Console.WriteLine("*******************************************************************");

        //    var result6 = rentalManager.GetRentalById(3);
        //    if (result6.Success)
        //    {
        //        Console.WriteLine("Rental Id : " + result6.Data.RentalId);

        //    }
        //    else
        //    {
        //        Console.WriteLine(result6.Message);
        //    }

        //    Console.WriteLine("*******************************************************************");

        //    //var result7 = rentalManager.GetRentalById(7);
        //    //Rental deletedRental = null;
        //    //if (result7.Success)
        //    //{
        //    //    deletedRental = result7.Data;

        //    //}
        //    //rentalManager.Delete(deletedRental);

        //    Console.WriteLine("*******************************************************************");

        //    var result8 = rentalManager.GetRentalDetails();
        //    if (result8.Success)
        //    {
        //        foreach (var rental in result8.Data)
        //        {
        //            Console.WriteLine(rental.CarName + " / " + rental.CustomerName + " / " + rental.UserName + " / " + rental.RentDate + " / " + rental.ReturnDate);
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine(result8.Message);
        //    }
        }
    }
}
