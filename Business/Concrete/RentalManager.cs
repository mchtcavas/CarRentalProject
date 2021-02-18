using Business.Abstract;
using Business.Constants;
using Core.Utilities;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
            
        }
        public IResult Add(Rental rental)
        {
            var result = CheckRentalCar(rental.CarId);
            if (!result.Success)
            {
                return new ErrorResult(Messages.CarCanNotBeRented);
            }
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.CarCanBeRented);
        }

        public IResult CheckRentalCar(int carId)
        {
            var result = _rentalDal.GetAll(c => c.CarId == carId && c.ReturnDate == null );
            if (result.Count>0)
            {
                return new ErrorResult();
            }
            return new SuccessResult();
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult();
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult();
        }
    }
}
