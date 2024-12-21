using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB.Models
{
    public class Ticket
    {
        public int ID { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int CustomerID { get; set; }
        public int FlightID { get; set; }
        public string PNR { get; set; }
        public string SeatNumber { get; set; }
    }

}