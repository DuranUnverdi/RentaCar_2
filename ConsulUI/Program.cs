using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsulUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetByUnitPrice(100,200))
            {
                Console.WriteLine(car.BrandId+" "+car.Description+" "+car.DailyPrice);
            }

        }
    }
}
