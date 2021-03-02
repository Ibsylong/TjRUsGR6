using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TjRUsGR6.Models
{
    public class Clothing
    {
        public int ClothingID { get; set; }
        public string Title { get; set; }

        public string Category { get; set; }

        public string Type { get; set; }

        public string Description { get; set; }

        public string Sizes { get; set; }

        public string Colors { get; set; }

        public double Price { get; set; }

        public string Images { get; set; }
    }
}
