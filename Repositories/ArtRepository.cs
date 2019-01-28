using System;
using System.Collections.Generic;
using DdArtSupply.Models;

namespace DdArtSupply.Repositories
{
    public class ArtRepository : IArtRepository
    {
        public ArtRepository()
        {
        }

        public List<Art> FeaturedArtworks => throw new NotImplementedException();

        List<Art> IArtRepository.Artworks
        {
            get
            {
                return new List<Art>
                {
                    new Art{
                        Id = 1,
                        Title = "Oceans III",
                        Medium = "Mixed media acrylic",
                        Year = 2016,
                        Width = 50,
                        Height = 70,
                        Price = 500,
                        Collection = Art.Collections.Oceans
                    },
                    new Art{
                        Id = 2,
                        Title = "Negative Nothing I",
                        Medium = "Mixed media ink",
                        Year = 2018,
                        Width = 100,
                        Height = 100,
                        Price = 1500,
                        Collection = Art.Collections.Atmosphere

                    },
                    new Art{
                        Id = 3,
                        Title = "Psychedlic Grass Painting",
                        Medium = "Mixed media acrylic",
                        Year = 2018,
                        Width = 80,
                        Height = 100,
                        Price = 1000,
                        Collection = Art.Collections.Abstracts
                    }
                };
            }
        }

        public Art GetArtworkById(int artworkId)
        {
            throw new NotImplementedException();
        }
    }
}
