using System.ComponentModel.DataAnnotations;

namespace Portfolio_Core_Project.Areas.Writer.Models
{
    public class UserLoginViewModel
    {
        [Display(Name ="Kullanıcı Adı")]
        [Required(ErrorMessage ="Kullanıcı Adını Giriniz...")]
        public string UserName { get; set; }
        

        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Kullanıcı Şifresini Giriniz...")]
        public string Password { get; set; }
    }
}
