using Business.Concrete;
using DataAccess.InMemory;
using System;

namespace Consolee
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager( new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarBrandId);
            }
        }
    }
}
