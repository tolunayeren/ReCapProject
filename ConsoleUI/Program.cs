using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
             CarTest();
           // BrandTest();
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.brandName);
            }
            Console.WriteLine(brandManager.GetById(2).Data.brandName);
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if(result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(
                        car.CarId + " " + car.ColorName + " " + car.BrandName + " " +
                        car.CarName + " " + car.DailyPrice + " " + car.ModelYear
                        );
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            
        }
    }
}
