using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaxiStation_Core2_EFCore.Models.Registrarion
{
    public class RegisterDriver
    {
        public RegisterDriver()
        {
        }

        [Required]
        [Display(Name = "Имя")]
        public string First_name { get; set; }
        [Required]
        [Display(Name = "Фамилия")]
        public string Second_name { get; set; }
        [Required]
        [Display(Name = "Дата рождения")]
        [DataType(DataType.Date)]
        public System.DateTime Birth_date { get; set; }
        [Required]
        [Display(Name = "Пол")]
        public bool Sex { get; set; }
        [Key]
        [Required]
        [Display(Name = "Номер телефона")]
        [DataType(DataType.PhoneNumber)]
        public string Phone_number { get; set; }
        [Required]
        [Display(Name = "Номер паспорта")]
        public string Pass_number { get; set; }
        [Required]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        [Display(Name = "Повторите пароль")]
        [DataType(DataType.Password)]
        public string Password_confirm { get; set; }

    }
}
