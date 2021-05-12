using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsulUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
            //RentInfoTest();
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.BrandName + " " + car.Description + " " + car.DailyPrice+" "+car.ColorName+" "+car.VehicleName+" "+car.ModelYear);
            }
        }

        private static void RentInfoTest()
        {
            RentInfoManager rentinfoManager = new RentInfoManager(new EfRentInfoDal());
            foreach (var rentinfo in rentinfoManager.GetAll())
            {
                Console.WriteLine(rentinfo.Id);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetByUnitPrice(100, 200))
            {
                Console.WriteLine(car.BrandId + " " + car.Description + " " + car.DailyPrice);
            }
        }
    }
}
