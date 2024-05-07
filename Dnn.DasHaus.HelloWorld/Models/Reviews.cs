using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DasHaus.Dnn.Dnn.DasHaus.HelloWorld.Models
{
    public partial class Reviews
    {
        public int Id { get; set; }
        public string HotCakesId { get; set; }
        public int ProductId { get; set; }
        public int Rating { get; set; }

        public virtual Products Product { get; set; }
    }
}
