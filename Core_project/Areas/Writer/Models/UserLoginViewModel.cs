using System.ComponentModel.DataAnnotations;

namespace Core_project.Areas.Writer.Models
{
    public class UserLoginViewModel
    {

        [Display(Name ="Kullanıcı adı")]
        [Required(ErrorMessage ="Kullanıcı adını girin.")]
        public string UserName { get; set; }
        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Şifreyi girin.")]
        public string Password { get; set; }
    }
}
