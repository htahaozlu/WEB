using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB.Models
{
    public class Plane
    {
        public int ID { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string Type { get; set; }
        public int BusinessClassCapacity { get; set; }
        public int EconomyClassCapacity { get; set; }
    }

}