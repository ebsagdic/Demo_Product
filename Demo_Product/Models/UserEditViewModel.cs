using System.ComponentModel.DataAnnotations;

namespace Demo_Product.Models
{
    public class UserEditViewModel
    {
        [Required(ErrorMessage = "Lütfen isim giriniz")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen soyisim giriniz")]
        public string SurName { get; set; }

        [Required(ErrorMessage = "Lütfen mail giriniz")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Lütfen şifre giriniz")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Şifrelerin eşleştiğinden emin olun")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Lütfen Cinsiyet giriniz")]
        public string Gender { get; set; }
    }
}
