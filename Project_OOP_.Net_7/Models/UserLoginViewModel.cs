using System.ComponentModel.DataAnnotations;

namespace Project_OOP_.Net_7.Models
{
    public class UserLoginViewModel
    {
        [Required(ErrorMessage = "Lütfen Kullanıcı Adınızı Giriniz")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen Şifrenizi Giriniz")]
        public string Password { get; set; }
    }
}
