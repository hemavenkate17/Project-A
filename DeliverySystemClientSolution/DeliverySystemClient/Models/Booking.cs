using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DeliverySystemClient.Models
{
    public class Booking
    {
        [Key]
        public int OrderID { get; set; }

        [ForeignKey("ID")]
        public int CustomerID { get; set; }
        public virtual Customer customer { get; set; }

        [ForeignKey("ID")]
        public int ExecutiveID { get; set; }
        public virtual Executive executive { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime PickUpDateTime { get; set; }
        public string BookingStatus { get; set; }

        public double WeightOfPackage { get; set; }
        public double Price { get; set; }

    }
}
