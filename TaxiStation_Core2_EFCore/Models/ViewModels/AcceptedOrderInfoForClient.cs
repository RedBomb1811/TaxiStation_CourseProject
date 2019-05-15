using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TaxiStation_Core2_EFCore.Models.ViewModels
{
    public class AcceptedOrderInfoForClient
    {
        [Key]
        public long order_id { get; set; }
        public string id_client { get; set; }
        public System.DateTime date_start_order { get; set; }
        public string name { get; set; }
        public double rate { get; set; }
        public double start_point_lat { get; set; }
        public double start_point_long { get; set; }
        public double end_point_lat { get; set; }
        public double end_point_long { get; set; }
        public bool pets { get; set; }
        public bool child { get; set; }
        public string driver_id { get; set; }
        public string driver_name { get; set; }
        public double rating { get; set; }
        public string model { get; set; }
        public string number { get; set; }
        public bool end_confirm_driver { get; set; }
    }
}
