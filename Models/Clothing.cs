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

        public ICollection<Size> Sizes { get; set; }

        public ICollection<Color> Colors { get; set; }

        public double Prize { get; set; }

        public ICollection<Image> Images { get; set; }
    }
}
