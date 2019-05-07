using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaxiStation_Core2_EFCore.Models.ViewModels
{
    public class MakeOrder 
    {
        [Key]
        [Required]
        [Display(Name = "Номер телефона")]
        [DataType(DataType.PhoneNumber)]
        public string Phone_number { get; set; }
        [Required]
        [Display(Name = "Тип заказа")]
        public int Id_order_type { get; set; }
        [Required]
        [Display(Name = "Начало поездки 1")]
        public float Start_point_lat { get; set; }
        [Required]
        [Display(Name = "Начало поездки 2")]
        public float Start_point_long { get; set; }
        [Required]
        [Display(Name = "Конец поездки 1")]
        public float End_point_lat { get; set; }
        [Required]
        [Display(Name = "Конец поездки 2")]
        public float End_point_long { get; set; }
        [Required]
        [Display(Name = "С животными")]
        public bool Pets { get; set; }
        [Required]
        [Display(Name = "с детьми")]
        public bool Child { get; set; }

    }
}
