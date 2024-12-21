using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB.Models
{
    public class Location
    {
        public int ID { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string Name { get; set; }

        // Self-referencing relationship
        public int? ParentID { get; set; }
        public virtual Location Parent { get; set; } // Navigation property
        public virtual ICollection<Location> Children { get; set; } // Child locations
    }


}