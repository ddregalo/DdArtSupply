using System;
using System.Collections.Generic;
using DdArtSupply.Models;

namespace DdArtSupply.Repositories
{
    public interface IArtRepository
    {
        List<Art> Artworks { get; }

        List<Art> FeaturedArtworks { get; }

        Art GetArtworkById(int artworkId);
    }
}
