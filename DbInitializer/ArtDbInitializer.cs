using System;
using DdArtSupply.Models.DbContext;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using DdArtSupply.Models;

namespace DdArtSupply.DbInitializer
{
    public class ArtDbInitializer
    {
        public ArtDbInitializer()
        {
        }

        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            ArtDbContext artDbContext =
                applicationBuilder.ApplicationServices.GetRequiredService<ArtDbContext>();

            if(!artDbContext.Artworks.Any())
            {
                artDbContext.AddRange(
                    new Art { Id = 1, ImageSource = "https://static.wixstatic.com/media/a9b3e0_7013392167714025804c9479d7cf35f5~mv2.jpg/v1/fill/w_916,h_916,al_c,q_90,usm_0.66_1.00_0.01/a9b3e0_7013392167714025804c9479d7cf35f5~mv2.webp", Title = "Oceans VII", Medium = "Acrylic and plaster canvas", Year = 2017, Width = 100, Height = 100, Price = 2500, Collection = Art.Collections.Oceans },
                    new Art { Id = 2, ImageSource = "https://static.wixstatic.com/media/a9b3e0_93e00627aea24022a63ae398860b44df~mv2_d_1558_2008_s_2.jpg/v1/crop/x_0,y_64,w_1558,h_1884/fill/w_850,h_1028,al_c,q_90,usm_0.66_1.00_0.01/a9b3e0_93e00627aea24022a63ae398860b44df~mv2_d_1558_2008_s_2.webp", Title = "Universe Dust", Medium = "Mixed media on canvas" , Year = 2018, Width = 60 , Height = 80, Price = 1400, Collection = Art.Collections.Atmosphere },
                    new Art { Id = 3, ImageSource = "https://static.wixstatic.com/media/a9b3e0_66ee7393974d4411a90c13626e155335~mv2_d_2756_2201_s_2.jpg/v1/fill/w_1424,h_1138,al_c,q_85,usm_0.66_1.00_0.01/a9b3e0_66ee7393974d4411a90c13626e155335~mv2_d_2756_2201_s_2.webp", Title = "Alberta Sky", Medium = "Acrylic and spray paint on canvas", Year = 2018, Width = 180, Height = 120, Price = 3800, Collection = Art.Collections.Horizons },
                    );
            }

            artDbContext.SaveChanges();
        }
    }
}
