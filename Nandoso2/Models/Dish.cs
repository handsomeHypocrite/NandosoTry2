using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nandoso2.Models
{
    public class Dish
    {
        public int ID { get; set; }
        public string DishName { get; set; }
        public string Describtion { get; set; }
        public int Price { get; set; }
        public bool Special { get; set; }

        //[JsonIgnore]
        //public virtual ICollection<Enrollment> Enrollments { get; set; }
    }   
}