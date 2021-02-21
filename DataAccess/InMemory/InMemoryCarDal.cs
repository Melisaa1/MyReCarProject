using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car {CarId=1, CategoryId=1, CarBrandId ="BMW", CarColorId = "siyah", CarModelYear= 1996, CarDailyPrice= 15000 },
                new Car {CarId=2, CategoryId=1, CarBrandId ="Mercedes", CarColorId = "mavi", CarModelYear= 1998, CarDailyPrice= 12000 },
                new Car {CarId=3, CategoryId=2,CarBrandId ="Megane", CarColorId = "yeşil", CarModelYear= 2000, CarDailyPrice= 10000 },
                new Car {CarId=4, CategoryId=2, CarBrandId ="symbol", CarColorId = "sarı", CarModelYear= 2011, CarDailyPrice= 8000 },
                new Car {CarId=5, CategoryId=2,CarBrandId ="clio", CarColorId = "pembe", CarModelYear= 2002, CarDailyPrice= 6000 }
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        

        public void Delete(Car car)
        {
            Car CarToDelete;
            CarToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId); 
        }

        
        public List<Car> GetAll()
        {
            return _cars;
        }

       

        public void UpDate(Car car)
        {
            Car carToUpDate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpDate.CarColorId = car.CarColorId;
            carToUpDate.CarDailyPrice = car.CarDailyPrice;
            carToUpDate.CarBrandId = car.CarBrandId;
            carToUpDate.CarModelYear = car.CarModelYear;
            carToUpDate.CategoryId = car.CategoryId;
        }

        List<Car> ICarDal.GetByld()
        {
            throw new NotImplementedException();
        }
    }
}
