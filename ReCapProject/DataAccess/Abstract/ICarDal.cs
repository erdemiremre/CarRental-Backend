using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal:IEntityRepository<Car>
    {
        List<CarDetailDto> GetCarDetails();
        List<CarDetailsWithImage> GetCarDetailsWithImageById(int carId);
        List<CarDetailsWithImage> GetCarDetailsWithImage();
        List<CarDetailsWithImage> GetFilteredCars(int brandId, int colorId, decimal minDailyPrice, decimal maxDailyPrice);
    }
}
