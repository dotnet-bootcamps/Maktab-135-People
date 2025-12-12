using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Food.EndPoints.UI.Models.Account
{
    public class LoginViewModel
    {
        [Display(Name = "نام کاربری")]
        [Required(ErrorMessage = "لطفا نام کاربری خود را وارد کنید.")]
        [EmailAddress(ErrorMessage = "لطفا یک ایمیل معتبر وارد کنید.")]
        public string Email { get; set; }

        [Display(Name = "رمز عبور")]
        [Required(ErrorMessage = "لطفا رمز عبور خود را وارد کنید.")]
        public string Password { get; set; }

        [Display(Name = "مرا به خاطر بسپار")]
        public bool RememberMe { get; set; }
    }
}
