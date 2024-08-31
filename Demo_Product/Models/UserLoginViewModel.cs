using System.ComponentModel.DataAnnotations;

namespace Demo_Product.Models
{
    public class UserLoginViewModel
    {
        [Required(ErrorMessage ="Lütfen kullanıcı adı girin")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen şifre girin")]
        public string Password { get; set; }

    }
}
