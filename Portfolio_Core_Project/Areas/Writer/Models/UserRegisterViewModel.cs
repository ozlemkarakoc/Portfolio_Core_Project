using System.ComponentModel.DataAnnotations;

namespace Portfolio_Core_Project.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen Kullanıcı Adını Girin!")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen Kullanıcı Şifreyi Girin!")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen Kullanıcı Şifreti Tekrar Girin!")]
        [Compare("Password", ErrorMessage = "Şifreler Uyumlu Değil!")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Lütfen Mail Adresini Girin")]
        public string Mail { get; set; }
    }
}
