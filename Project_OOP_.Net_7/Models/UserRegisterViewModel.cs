using System.ComponentModel.DataAnnotations;

namespace Project_OOP_.Net_7.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage ="Lütfen Bir İsim Giriniz")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen Bir Soyisim Giriniz")]
        public string SurName { get; set; }

        [Required(ErrorMessage = "Lütfen Bir Kullanıcı Adı Giriniz")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen Bir EMail Giriniz")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Lütfen Bir Şifre Giriniz")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen Cinsiyetinizi Giriniz")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Lütfen Şifrenizi Tekrar Giriniz")]
        [Compare("Password", ErrorMessage ="Lütfen Şifrelerin Eşleştiğinden emin Olun")]
        public string ConfirmPassword { get; set; }
    }
}
