using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.CarName).NotEmpty();
            RuleFor(c => c.CarName).MinimumLength(2);
            RuleFor(c => c.DailyPrice).NotEmpty();
            RuleFor(c => c.DailyPrice).GreaterThan(500).When(c=>c.CarId==1).WithMessage("Gunluk kiralama bedeli 500 tl den az olamaz");
            RuleFor(c => c.DailyPrice).GreaterThan(200).When(c=>c.CarId==2).WithMessage("Gunluk kiralama bedeli 200 tl den az olamaz");
            RuleFor(c => c.DailyPrice).GreaterThan(450).When(c=>c.CarId==3).WithMessage("Gunluk kiralama bedeli 450 tl den az olamaz");
            RuleFor(c => c.DailyPrice).GreaterThan(550).When(c=>c.CarId==4).WithMessage("Gunluk kiralama bedeli 550 tl den az olamaz");
            RuleFor(c => c.DailyPrice).GreaterThan(250).When(c=>c.CarId==5).WithMessage("Gunluk kiralama bedeli 250 tl den az olamaz");
            RuleFor(c => c.DailyPrice).GreaterThan(1000).When(c=>c.CarId==6).WithMessage("Gunluk kiralama bedeli 1000 tl den az olamaz");
            RuleFor(c => c.DailyPrice).GreaterThan(150).When(c=>c.CarId==7).WithMessage("Gunluk kiralama bedeli 150 tl den az olamaz");
        }
    }
}
