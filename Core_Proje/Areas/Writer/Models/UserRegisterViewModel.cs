using System.ComponentModel.DataAnnotations;

namespace Core_Proje.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage ="Lütfen Adınızı Girin")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Lütfen Soyadını Girin")]
        public string Surname { get; set; }
        [Required(ErrorMessage ="Lütfen Resim Url Değeri Girin")]
        public string ImageUrl { get; set; }
        [Required(ErrorMessage = "Lütfen Kullanıcı Adınızı Girin")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Lütfen Şifrenizi Girin")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Lütfen Şifrenizi Tekrar Girin")]
        [Compare("Password",ErrorMessage ="Şifreniz uyumlu değil!")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Lütfen Mail Adresinizi Girin")]
        public string Mail { get; set; }
    }
}
