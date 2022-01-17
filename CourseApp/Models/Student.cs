using System.ComponentModel.DataAnnotations;

namespace CourseApp.Models
{
    public class Student
    {
        [Required(ErrorMessage = "İsminizi giriniz!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Soy isminizi giriniz!")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Email adresinizi giriniz!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Telefon numaranızı giriniz!")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Katılma durumunuz nedir?")]
        public bool? Confirm { get; set; } //true,false, null
    }
}
