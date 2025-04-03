using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace OgrenciBilgiSistemi.Models
{
    public class Student
    {
        public int Id { get;set; }

        [Required(ErrorMessage ="Öğrenci adı ve soyadı zorunludur." )]
        public string FullName { get;set; }

        [Required(ErrorMessage="Öğrenci yaşı zorunludur.")]
        public int Age { get; set; }

        [Required(ErrorMessage ="Öğrenci bölümü zorunludur.")]
        public string Department { get; set; }

        [Required(ErrorMessage ="Öğrenci e-posta adresi zorunludur..")]
        [EmailAddress(ErrorMessage="Geçerli bir e-posta adresi giriniz..")]
        public string Email { get; set; }   
    }
}
