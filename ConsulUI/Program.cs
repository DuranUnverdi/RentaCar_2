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
            CarTest();
            //RentInfoTest();
            // NewMethod();
        }

        private static void NewMethod()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(car.BrandName + " " + car.Description + " " + car.DailyPrice + " " + car.ColorName + " " + car.VehicleName + " " + car.ModelYear);
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
            var result = carManager.GetByUnitPrice(100, 200);
            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.BrandId + " " + car.Description + " " + car.DailyPrice);
                }
            }
            else
            {
                Console.Write(result.Message);
            }

        }
    }
}
