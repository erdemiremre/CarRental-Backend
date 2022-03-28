using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IDataResult<List<CarDetailsWithImage>> GetCarDetailsWithImage();
        IDataResult<List<CarDetailsWithImage>> GetCarDetailsWithImageById(int carId);
        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);
        IDataResult<List<Car>> GetCarsByBrandId(int id);
        IDataResult<Car> GetById(int id);
        IDataResult<List<CarDetailDto>> GetByColorId(int colorId);
        IDataResult<List<CarDetailsWithImage>> GetFilteredCars(int brandId, int colorId, decimal minDailyPrice, decimal maxDailyPrice);
        IDataResult<List<CarDetailsWithImage>> GetByFilteredCars(CarFilterDetailDto filterDto);
    }
}
