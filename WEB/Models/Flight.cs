using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB.Models
{
    public class Flight
    {
        public int ID { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int AirportID { get; set; }
        public int CompanyID { get; set; }
        public int PlaneID { get; set; }
        public int DepartureLocationID { get; set; }
        public int ArrivalLocationID { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime Date { get; set; }
        public decimal BusinessPrice { get; set; }
        public decimal EconomyPrice { get; set; }
        public bool isCanceled { get; set; }
    }

}