using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaxiStation_Core2_EFCore.Models.ViewModels
{
    public class MakeOrder 
    {
        public string Phone_number { get; set; }
        public int Id_order_type { get; set; }
        public float Start_point_lat { get; set; }
        public float Start_point_long { get; set; }
        public float End_point_lat { get; set; }
        public float End_point_long { get; set; }
        public bool Pets { get; set; }
        public bool Child { get; set; }

    }
}
