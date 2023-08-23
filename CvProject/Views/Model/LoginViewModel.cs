using System.ComponentModel.DataAnnotations;

namespace CvProject.Views.Model
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Lütfen Kullanıcı Adını Giriniz.")]
        public string userName { get; set; }

        [Required(ErrorMessage = "Lütfen Şifrenizi Giriniz.")]
        public string password { get; set; }

    }
}
