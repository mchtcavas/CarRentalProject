using Business.Abstract;
using Core.CrossCuttingConcerns.Check;
using Core.CrossCuttingConcerns.Check.Abstract;
using Core.Entities;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CheckRentalCarManager:ICheckService
    {
        IRentalDal _rentalDal;
        Rental _rental;
        public CheckRentalCarManager(IRentalDal rentalDal, Rental rental)
        {
            _rental = rental;
            _rentalDal = rentalDal;
        }
        public IResult Check()
        {
            var result = _rentalDal.GetAll(c => c.CarId == _rental.CarId && c.ReturnDate == null);
            if (result.Count > 0)
            {
                return new ErrorResult();
            }
            return new SuccessResult();
        }


      


    }
}
