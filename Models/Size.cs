﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TjRUsGR6.Models
{
    public class Size
    {
        [Key]
        public int ClothingSizeID { get; set; }
        public int ClothingSize { get; set; }
    }
}
