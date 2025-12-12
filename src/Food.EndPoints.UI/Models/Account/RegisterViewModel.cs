using System.ComponentModel.DataAnnotations;

namespace Food.EndPoints.UI.Models.Account;

public class RegisterViewModel
{
    [Display(Name = "نام کاربری (ایمیل)")]
    [Required(ErrorMessage = "لطفا ایمیل خود را وارد کنید.")]
    [EmailAddress(ErrorMessage = "لطفا یک ایمیل معتبر وارد کنید.")]
    public string Email { get; set; }


    [Display(Name = "شماره همراه")]
    [Required(ErrorMessage = "لطفا شماره همراه خود را وارد کنید.")]
    //[Phone(ErrorMessage = "لطفا یک شماره همراه معتبر وارد کنید.")]
    public string PhoneNumber { get; set; }

    [Display(Name = "رمز عبور")]
    [Required(ErrorMessage = "لطفا رمز عبور خود را وارد کنید.")]
    [MinLength(7, ErrorMessage = "رمز عبور باید حداقل 7 کاراکتر باشد.")]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [Display(Name = "تکرار رمز عبور")]
    [Required(ErrorMessage = "لطفا تکرار رمز عبور خود را وارد کنید.")]
    [Compare("Password", ErrorMessage = "رمز عبور و تکرار آن مطابقت ندارند.")]
    [DataType(DataType.Password)]
    public string ConfirmPassword { get; set; }

}