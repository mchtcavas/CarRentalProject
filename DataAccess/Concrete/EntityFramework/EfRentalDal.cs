using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapDBContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (ReCapDBContext context = new ReCapDBContext())
            {
                var result = from rental in context.Rentals
                             join customer in context.Customers
                             on rental.CustomerId equals customer.CustomerId
                             join user in  context.Users
                             on customer.UserId equals user.UserId
                             join car in context.Cars
                             on rental.CarId equals car.CarId
                             join brand in context.Brands
                             on car.BrandId equals brand.BrandId
                             
                             select new RentalDetailDto
                             {
                                BrandName = brand.BrandName,
                                FirstName = user.UserFirstName,
                                LastName = user.UserLastName,
                                RentalId = rental.RentalId,
                                RentDate = rental.RentDate,
                                ReturnDate = rental.ReturnDate
                             };
                return result.ToList();

            }
        }
    }
}
