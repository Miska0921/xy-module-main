using System;
using System.Collections.Generic;
using DotNetNuke.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DasHaus.Dnn.Dnn.DasHaus.HelloWorld.Models
{
    public partial class Products
    {
        public Products()
        {
            Reviews = new HashSet<Reviews>();
        }

        public int Id { get; set; }
        public string HotCakesId { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public double Price { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Length { get; set; }
        public double Weight { get; set; }

        public virtual Categories Category { get; set; }
        public virtual ICollection<Reviews> Reviews { get; set; }
    }
}
