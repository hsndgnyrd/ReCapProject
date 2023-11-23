using Business.Concrete;
using DataAccess.Concrete.EntitiyFramework;
using DataAccess.Concrete.InMemory;
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
            CarManager carManager = new CarManager(new EFCarDal());

            foreach (var car in carManager.GetCarsByBrandId(1))
            {

            System.Console.WriteLine("{0} - {1} - {2} - {3}",car.CarId,car.BrandId,car.ColorId,car.Description);
            }

        }
    }
}