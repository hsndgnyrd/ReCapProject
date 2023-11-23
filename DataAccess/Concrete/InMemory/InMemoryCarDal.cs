using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> { 
                new Car{CarId = 1, BrandId = 1, ColorId = 1, DailyPrice=50000, Description="Yeni alındı", ModelYear=2022},
                new Car{CarId = 2, BrandId = 2, ColorId = 2, DailyPrice=950000, Description="Sıfır", ModelYear=2023},
                new Car{CarId = 3, BrandId = 3, ColorId = 3, DailyPrice=750000, Description="Dosta gider", ModelYear=1999},
                new Car{CarId = 4, BrandId = 2, ColorId = 2, DailyPrice=250000, Description="Takas Düşünülür", ModelYear=2014},
                new Car{CarId = 5, BrandId = 1, ColorId = 1, DailyPrice=1500000, Description="Ağır hasarlı", ModelYear=2009},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
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

        public Car GetById(int id)
        {
            return _cars.Find(c => c.CarId == id);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.DailyPrice = 1000;
            carToUpdate.ModelYear = 2024;
            carToUpdate.Description = "Kaza yapıldı.";
            carToUpdate.ColorId = 5; 
        }
    }
}
