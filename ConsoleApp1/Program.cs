using Business.Concrete;
using Core.Entities.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //AddTest();
            //GetAllTest();
            //GetByCarId();
            //GetByDailyPriceTest();
            //UpdateTest();
            //ColorAddTest();
            //BrandAddTest();
            //CarDetailTest();
            //Test2();
            //UserAdd();
            //CustomerAdd();
            //RentCarTest();

            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.Add(new Rental { CarId = 1, CustomerId = 1, RentDate = "2/15/2021" });
            Console.WriteLine(result.Messages);



        }

        private static void RentCarTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            rentalManager.Add(new Rental { CarId = 1, CustomerId = 1, RentDate = "2/15/2021" });
            rentalManager.Add(new Rental { CarId = 2, CustomerId = 2, RentDate = "23/15/2021" });
            rentalManager.Add(new Rental { CarId = 3, CustomerId = 3, RentDate = "2/15/2021" });
            rentalManager.Add(new Rental { CarId = 4, CustomerId = 4, RentDate = "15/15/2021" });
            rentalManager.Add(new Rental { CarId = 5, CustomerId = 5, RentDate = "2/15/2021" });
            rentalManager.Add(new Rental { CarId = 6, CustomerId = 6, RentDate = "6/15/2021" });
            rentalManager.Add(new Rental { CarId = 7, CustomerId = 7, RentDate = "4/15/2021" });
            rentalManager.Add(new Rental { CarId = 8, CustomerId = 8, RentDate = "27/15/2021" });
            rentalManager.Add(new Rental { CarId = 9, CustomerId = 9, RentDate = "1/15/2021" });
            rentalManager.Add(new Rental { CarId = 10, CustomerId = 10, RentDate = "13/15/2021" });
            rentalManager.Add(new Rental { CarId = 11, CustomerId = 11, RentDate = "22/15/2021" });
        }

        private static void CustomerAdd()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            var result = customerManager.Add(new Customer { CompanyName = "DuranAhmet A.S", UserId = 2 });
            Console.WriteLine(result.Messages);
        }

        private static void UserAdd()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            var result = userManager.Add(new User { UserFirstName = "Nazli", UserLastName = "Caliskan", UserEmail = "nazliCaliskan@gmail.com" });
            Console.WriteLine(result.Messages);
        }

        private static void Test2()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.Add(new Car { CarId = 10, CarName = "Reno V1", DailyPrice = 900, BrandId = 2, ColorId = 3 });
            Console.WriteLine(result.Messages);
        }

        private static void CarDetailTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var results = carManager.GetCarDetails();
            foreach (var detail in results.Data)
            {
                Console.WriteLine(detail.CarName + "/" + detail.BrandName);
            }
        }

        private static void BrandAddTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            brandManager.Add(new Brand { BrandId = 1, BrandName = "Mercedes" });
            brandManager.Add(new Brand { BrandId = 2, BrandName = "Honda" });
            brandManager.Add(new Brand { BrandId = 3, BrandName = "Bmw" });
            brandManager.Add(new Brand { BrandId = 4, BrandName = "Togg" });
            brandManager.Add(new Brand { BrandId = 5, BrandName = "Hyundai" });
            brandManager.Add(new Brand { BrandId = 6, BrandName = "Ferrari" });
            brandManager.Add(new Brand { BrandId = 7, BrandName = "Ford" });
        }

        private static void ColorAddTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            colorManager.Add(new Color { ColorId = 1, ColorName = "Mavi" });
            colorManager.Add(new Color { ColorId = 2, ColorName = "Gri" });
            colorManager.Add(new Color { ColorId = 3, ColorName = "Beyaz" });
            colorManager.Add(new Color { ColorId = 4, ColorName = "Kirmizi" });
            colorManager.Add(new Color { ColorId = 5, ColorName = "Siyah" });
            colorManager.Add(new Color { ColorId = 6, ColorName = "Sari" });
            colorManager.Add(new Color { ColorId = 7, ColorName = "Yesil" });
        }

        private static void UpdateTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Update(new Car { CarId = 1, CarName = "Mercedes C200d", DailyPrice = 8000, BrandId = 1, ColorId = 3 });
            carManager.Update(new Car { CarId = 2, CarName = "Ferrari Marenello", DailyPrice = 18000, BrandId = 6, ColorId = 2 });
            carManager.Update(new Car { CarId = 3, CarName = "Bmw 118i", DailyPrice = 6500, BrandId = 3, ColorId = 4 });
            carManager.Update(new Car { CarId = 4, CarName = "Honda Civic", DailyPrice = 4000, BrandId = 2, ColorId = 7 });
            carManager.Update(new Car { CarId = 5, CarName = "Hyundai Tucson", DailyPrice = 4100, BrandId =5, ColorId = 3 });
            carManager.Update(new Car { CarId = 6, CarName = "Togg Turkey", DailyPrice = 6000, BrandId = 4, ColorId = 1 });
            carManager.Update(new Car { CarId = 7, CarName = "Ford Focus", DailyPrice = 1900, BrandId = 7, ColorId = 2 });
            carManager.Update(new Car { CarId = 8, CarName = "Mercedes A200", DailyPrice = 7500, BrandId = 1, ColorId = 5 });
            carManager.Update(new Car { CarId = 9, CarName = "Bmw 320i", DailyPrice = 6500, BrandId = 3, ColorId = 5 });
            carManager.Update(new Car { CarId = 10, CarName = "Ferrari Daytona", DailyPrice = 15000, BrandId = 6, ColorId = 1 });
            carManager.Update(new Car { CarId = 11, CarName = "Hyundai i30", DailyPrice = 2500, BrandId = 5, ColorId = 5 });
        }

        private static void GetByDailyPriceTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var results = carManager.GetByDailyPrice(2000, 6500);

            foreach (var car in results.Data)
            {
                Console.WriteLine(car.CarName);
            }
        }

        private static void GetByCarId()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var results = carManager.GetByCarId(6);
            Console.WriteLine(results.Data.CarName);
        }

        private static void AddTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            
            carManager.Update(new Car { CarId = 1, CarName = "Mercedes C200d", DailyPrice = 8000, BrandId = 1, ColorId = 3 });
            carManager.Update(new Car { CarId = 2, CarName = "Ferrari Marenello", DailyPrice = 18000, BrandId = 6, ColorId = 2 });
            carManager.Update(new Car { CarId = 3, CarName = "Bmw 118i", DailyPrice = 6500, BrandId = 3, ColorId = 4 });
            carManager.Update(new Car { CarId = 4, CarName = "Honda Civic", DailyPrice = 4000, BrandId = 2, ColorId = 7 });
            carManager.Update(new Car { CarId = 5, CarName = "Hyundai Tucson", DailyPrice = 4100, BrandId = 5, ColorId = 3 });
            carManager.Update(new Car { CarId = 6, CarName = "Togg Turkey", DailyPrice = 6000, BrandId = 4, ColorId = 1 });
            carManager.Update(new Car { CarId = 7, CarName = "Ford Focus", DailyPrice = 1900, BrandId = 7, ColorId = 2 });
            carManager.Update(new Car { CarId = 8, CarName = "Mercedes A200", DailyPrice = 7500, BrandId = 1, ColorId = 5 });
            carManager.Update(new Car { CarId = 9, CarName = "Bmw 320i", DailyPrice = 6500, BrandId = 3, ColorId = 5 });
            carManager.Update(new Car { CarId = 10, CarName = "Ferrari Daytona", DailyPrice = 15000, BrandId = 6, ColorId = 1 });
            carManager.Add(new Car { CarName = "Hyundai i30", DailyPrice = 2500, BrandId = 5, ColorId = 5 });
        }

        private static void GetAllTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var results = carManager.GetAll();

            foreach (var car in results.Data)
            {
                Console.WriteLine(car.CarName);
            }
        }
    }
}
