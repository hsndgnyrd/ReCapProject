using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntitiyFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car car = new Car { BrandId = 5, ColorId = 7, DailyPrice = 750, Description = "Sıfır araba ve ekleme denemesi", ModelYear = 2021};
            //CarManager carManager = new CarManager(new EFCarDal());
            //carManager.Add(car);

            //CarTest();
            //ColorTest();
            //BrandTest();

            RentCarTest();

        }

        private static void RentCarTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.Add(new Rental { CarId = 11, CustomerId = 1, RentDate = DateTime.Now });
            System.Console.WriteLine(result.Message);
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result = brandManager.GetAll();
            if (result.Success)
            {
                foreach (var brand in result.Data)
                {
                    System.Console.WriteLine(brand.BrandName);
                }
            }
            else
            {
                System.Console.WriteLine(result.Message);
            }
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var result = colorManager.GetAll();
            if (result.Success)
            {
                foreach (var color in result.Data)
                {
                    System.Console.WriteLine(color.ColorName);

                }
            }
            else
            {
                System.Console.WriteLine(result.Message);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EFCarDal());
            var result = carManager.GetProductDetails();
            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    System.Console.WriteLine("{0} - {1} - {2} - {3}",car.ColorName, car.BrandName, car.DailyPrice, car.CarName);
                }
            }
            else
            {
                System.Console.WriteLine(result.Message);
            }
        }
    }
}