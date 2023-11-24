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

            CarTest();
            //ColorTest();
            //BrandTest();

        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            foreach (var brand in brandManager.GetAll())
            {
                System.Console.WriteLine(brand.BrandName);
            }
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll())
            {
                System.Console.WriteLine(color.ColorName);

            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EFCarDal());
            foreach (var car in carManager.GetProductDetails())
            {
                System.Console.WriteLine("{0} - {1} - {2} - {3}",car.CarName, car.BrandName, car.ColorName, car.DailyPrice);
            }
        }
    }
}