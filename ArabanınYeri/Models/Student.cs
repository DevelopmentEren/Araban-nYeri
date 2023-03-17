using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArabanınYeri.Models
{
    public class Student
    {
        [Required(ErrorMessage ="Lütfen Adınızı Giriniz!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "E-posta alanı boş olamaz!")]
         [EmailAddress(ErrorMessage ="Lütfen e-posta adresinizi doğru giriniz!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Telefon Numarası alanı boş olamaz!")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Kursa katılıp katılmayacağınızı bildirmeniz gerekiyor!")]
        public bool? WillAttend { get; set; }
    }
}
