using Core.DataAccess.EntityFramework;

using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RecapDbContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (RecapDbContext context=new RecapDbContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join cl in context.Colors
                             on c.ColorId equals cl.ColorId
                             select new CarDetailDto
                             {
                                 BrandName = b.BrandName,
                                 ColorName = cl.ColorName,
                                 DailyPrice = c.DailyPrice,
                                 ColorId=cl.ColorId

                             };
                return result.ToList();            
            }

        }

        public List<CarDetailsWithImage> GetCarDetailsWithImageById(int carId)
        {
            using (RecapDbContext context = new RecapDbContext())
            {
                var result = from car in context.Cars
                             join color in context.Colors
                             on car.ColorId equals color.ColorId
                             join brand in context.Brands
                             on car.BrandId equals brand.BrandId
                             //join carimage in context.CarImages
                             //on car.CarId equals carimage.CarId
                             where car.CarId == carId
                             select new CarDetailsWithImage
                             {
                                 CarId = car.CarId,
                                 BrandName = brand.BrandName,
                                 ColorName = color.ColorName,
                                 Model = car.Model,
                                 ModelYear = car.ModelYear,
                                 DailyPrice = car.DailyPrice,
                                 //ImagePath = carimage.ImagePath,
                                 ImagePath=(from i in context.CarImages where i.CarId == car.CarId select i.ImagePath).ToList(),
                                 Description = car.Description

                             };

                return result.ToList();
            }
        }

        public List<CarDetailsWithImage> GetCarDetailsWithImage()
        {
            using (RecapDbContext context = new RecapDbContext())
            {
                var result = from car in context.Cars
                             join color in context.Colors
                             on car.ColorId equals color.ColorId
                             join brand in context.Brands
                             on car.BrandId equals brand.BrandId
                             //join carimage in context.CarImages
                             //on car.CarId equals carimage.CarId
                             select new CarDetailsWithImage
                             {
                                 CarId = car.CarId,
                                 BrandName = brand.BrandName,
                                 ColorName = color.ColorName,
                                 Model = car.Model,
                                 ModelYear = car.ModelYear,
                                 DailyPrice = car.DailyPrice,
                                 //ImagePath = carimage.ImagePath,
                                 ImagePath = (from i in context.CarImages where i.CarId == car.CarId select i.ImagePath).ToList(),
                                 Description = car.Description

                             };

                return result.ToList();
            }
        }

        public List<CarDetailsWithImage> GetFilteredCars(int brandId, int colorId, decimal minDailyPrice, decimal maxDailyPrice)
        {
            using (RecapDbContext context=new RecapDbContext())
            {
                var result = from car in context.Cars
                             join color in context.Colors
                             on car.ColorId equals color.ColorId
                             join brand in context.Brands
                             on car.BrandId equals brand.BrandId
                             where car.BrandId == brandId
                             && car.ColorId == colorId
                             && car.DailyPrice >= minDailyPrice
                             && car.DailyPrice <= maxDailyPrice
                             select new CarDetailsWithImage
                             {
                                 CarId = car.CarId,
                                 BrandName = brand.BrandName,
                                 ColorName = color.ColorName,
                                 Model = car.Model,
                                 ModelYear = car.ModelYear,
                                 DailyPrice = car.DailyPrice,
                                 //ImagePath = carimage.ImagePath,
                                 ImagePath = (from i in context.CarImages where i.CarId == car.CarId select i.ImagePath).ToList(),
                                 Description = car.Description

                             };
                //select new CarDetailDto
                //{
                //    CarId = car.CarId,
                //    BrandName = brand.BrandName,
                //    ColorName = color.ColorName,
                //    Model = car.Model,
                //    ModelYear = car.ModelYear,
                //    DailyPrice = car.DailyPrice

                //};

                return result.ToList();
            }
        }
    }
}
