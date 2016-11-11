using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotell.Models
{
    public class Booking
    {

        public int BookingID { get; set; }

        public bool IsAviable { get; set; }

        public int FinalPrice { get; set; }

        public Customer Customer { get; set; }
    }
}