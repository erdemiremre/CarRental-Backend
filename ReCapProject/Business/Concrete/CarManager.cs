using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        
        [ValidationAspect(typeof(CarValidator))]
        //[SecuredOperation("product.add")]
        public IResult Add(Car car)
        {
            BusinessRules.Run();
                _carDal.Add(car);
                return new SuccessResult(Messages.CarAdded);
        }
        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
        }
        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.CarUpdated);
        }

        public IDataResult<Car> GetById(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.CarId == id),Messages.CarListed);
        }
        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.CarListed);
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == id));
        }

        public IDataResult<List<CarDetailDto>> GetByColorId(int colorId)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails().Where(c=>c.ColorId==colorId).ToList());
        }

        public IDataResult<List<CarDetailsWithImage>> GetFilteredCars(int brandId, int colorId, decimal minDailyPrice, decimal maxDailyPrice)
        {
            return new SuccessDataResult<List<CarDetailsWithImage>>(_carDal.GetFilteredCars(brandId, colorId, minDailyPrice, maxDailyPrice),Messages.CarListed);
        }

        public IDataResult<List<CarDetailsWithImage>> GetCarDetailsWithImage()
        {
            return new SuccessDataResult<List<CarDetailsWithImage>>(_carDal.GetCarDetailsWithImage());
        }

        public IDataResult<List<CarDetailsWithImage>> GetCarDetailsWithImageById(int carId)
        {
            return new SuccessDataResult<List<CarDetailsWithImage>>(_carDal.GetCarDetailsWithImageById(carId));
        }
    }
}
