using System.ComponentModel.DataAnnotations;

namespace Core_project.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage ="Lütfen kullanıcı adını girin.")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Lütfen şifreyi girin.")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Lütfen şifreyi tekrar girin.")]
        [Compare("Password",ErrorMessage ="Şifreler uyumlu değil.")] //Password entity'si ile karşılaştırıyor.
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Lütfen Mail girin.")]
        public string Mail { get; set; }
    }
}
