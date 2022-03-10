using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //CarTest();

            ColorListTest();

        }

        private static void ColorListTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var item in colorManager.GetAll().Data)
            {
                Console.WriteLine(item.ColorName);
            }

            //Console.WriteLine(colorManager.GetById(1).Data.ColorId);
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var item in carManager.GetCarDetails().Data)
            {
                Console.WriteLine("Marka : "+item.BrandName);
                Console.WriteLine("Renk : "+item.ColorName);
                Console.WriteLine("Ücret : "+item.DailyPrice);
            }
        }
    }
}
