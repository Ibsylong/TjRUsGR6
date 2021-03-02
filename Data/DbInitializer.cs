using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TjRUsGR6.Models;

namespace TjRUsGR6.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ClothingContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Clothings.Any())
            {
                return;   // DB has been seeded
            }

            var clothings = new Clothing[]
            {
            new Clothing{Title="Kjole1",Category="Dame",Type="Dress", Description="Dette er en kjole", Price=499.25},
            new Clothing{Title="Skjorte1",Category="Herre",Type="Shirt", Description="Dette er en skjorte", Price=25},
            new Clothing{Title="Bukser1",Category="Børn",Type="Pants", Description="Et par bukser", Price=50.69},
            };
            foreach (Clothing c in clothings)
            {
                context.Clothings.Add(c);
            }
            context.SaveChanges();

            var colors = new Color[]
            {
            new Color{ColorID=1,ColorName="Red"},
            new Color{ColorID=2,ColorName="Blue"},
            new Color{ColorID=3,ColorName="Green"}
            };
            foreach (Color c in colors)
            {
                context.Colors.Add(c);
            }
            context.SaveChanges();

            var images = new Image[]
            {
            new Image{ImageID=1,ImageLink="nothing"},
            new Image{ImageID=2,ImageLink="no pic"},
            new Image{ImageID=3,ImageLink="send pic"},
            };
            foreach (Image i in images)
            {
                context.Images.Add(i);
            }
            context.SaveChanges();

            var sizes = new Size[]
            {
            new Size{ClothingSizeID=1,ClothingSize=21},
            new Size{ClothingSizeID=2,ClothingSize=24},
            new Size{ClothingSizeID=3,ClothingSize=26}
            };
            foreach (Size s in sizes)
            {
                context.Sizes.Add(s);
            }
            context.SaveChanges();
        }
    }
}
