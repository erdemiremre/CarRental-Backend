using Core.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator:AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.FirstName).NotEmpty().WithMessage("İsim boş geçilemez");
            RuleFor(u => u.FirstName).MinimumLength(2).WithMessage("İsim en az 2 karakterden oluşmalıdır");
            RuleFor(u => u.LastName).NotEmpty().WithMessage("Soyad boş geçilemez");
            RuleFor(u => u.LastName).MinimumLength(2).WithMessage("Soyad en az 2 karakterden oluşmalıdır");
            RuleFor(u => u.Email).NotEmpty().WithMessage("E-mail boş geçilemez");
            RuleFor(u => u.Email).EmailAddress().When(u => !string.IsNullOrEmpty(u.Email));
            RuleFor(u => u.Email).Must(IsEmailValid);
            
           
        }

        private bool IsEmailValid(string arg)
        {
            //Regular Expressions, yani  düzenli İfadeler, string bir değişkenin ya da bir metnin, verilen kalıpla eşleşip eşleşmediğini kontrol etmek için kullanılan bir modeldir.
            //using System.Text.RegularExpressions; kütüphanesinden gelir,
            //IsMatch : Bir stringin içinde, diğer bir string ya da bir ifadenin bulunup bulunmadığı bilgisini true/false olarak döner.

            Regex regex = new Regex(@"[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
            return regex.IsMatch(arg);
        }
    }
}
