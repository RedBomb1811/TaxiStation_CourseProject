using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaxiStation_Core2_EFCore.Models.ViewModels
{
    public class AddVenichle
    {
        [Key]
        [Required]
        [Display(Name = "Гос. номер")]
        public string number { get; set; }
        [Required]
        [Display(Name = "Дети")]
        public bool child { get; set; }
        [Required]
        [Display(Name = "Животные")]
        public bool pets { get; set; }
        [Required]
        [Display(Name = "Модель")]
        public string model { get; set; }
        [Required]
        [Display(Name = "Класс автомобиля")]
        public int id_venichle_type { get; set; }
    }
}
