using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DdArtSupply.Models;
using DdArtSupply.Models.DbContext;
using Microsoft.EntityFrameworkCore;

namespace DdArtSupply.Repositories
{
    public class ArtRepository : IArtRepository
    {
        private readonly ArtDbContext ArtDbContext;

        public ArtRepository(ArtDbContext artDbContext)
        {
            ArtDbContext = artDbContext;
        }

        public List<Art> Artworks => (from artwork in ArtDbContext.Artworks orderby artwork.Title select artwork).ToList();

        public List<Art> FeaturedArtworks => throw new NotImplementedException();

        public IQueryable<Art> GetAllArtworks() => ArtDbContext.Artworks.AsQueryable();

        public Art GetArtworkById(int artworkId)
        {
            return GetAllArtworks().Where(a => a.Id == artworkId).FirstOrDefault();
        }
    }
}






//new Art{
                    //    Id = 1,
                    //    ImageSource = "https://static.wixstatic.com/media/a9b3e0_2bf6347abc604aec91163a57681dd925~mv2_d_2165_3060_s_2.jpg/v1/fill/w_775,h_1096,al_c,q_90,usm_0.66_1.00_0.01/a9b3e0_2bf6347abc604aec91163a57681dd925~mv2_d_2165_3060_s_2.jpg",
                    //    Title = "Oceans III",
                    //    Medium = "Mixed media acrylic",
                    //    Year = 2016,
                    //    Width = 50,
                    //    Height = 70,
                    //    Price = 600,
                    //    Collection = Art.Collections.Oceans
                    //},
                    //new Art{
                    //    Id = 2,
                    //    ImageSource = "https://static.wixstatic.com/media/a9b3e0_93e00627aea24022a63ae398860b44df~mv2_d_1558_2008_s_2.jpg/v1/crop/x_0,y_64,w_1558,h_1884/fill/w_934,h_1232,al_c,q_85,usm_0.66_1.00_0.01/a9b3e0_93e00627aea24022a63ae398860b44df~mv2_d_1558_2008_s_2.jpg",
                    //    Title = "Universe",
                    //    Medium = "Mixed media ink",
                    //    Year = 2018,
                    //    Width = 60,
                    //    Height = 80,
                    //    Price = 800,
                    //    Collection = Art.Collections.Atmosphere

                    //},
                    //new Art{
                    //    Id = 3,
                    //    ImageSource = "https://static.wixstatic.com/media/a9b3e0_2384e0cda1e14276aad9c021b2c7f1fd~mv2_d_2996_2362_s_2.jpg/v1/fill/w_1532,h_1208,al_c,q_90,usm_0.66_1.00_0.01/a9b3e0_2384e0cda1e14276aad9c021b2c7f1fd~mv2_d_2996_2362_s_2.jpg",
                    //    Title = "New Frontiers",
                    //    Medium = "Mixed media acrylic and spray paint",
                    //    Year = 2018,
                    //    Width = 140,
                    //    Height = 120,
                    //    Price = 1000,
                    //    Collection = Art.Collections.Horizons
                    //}
