using System;
namespace DdArtSupply.Models
{
    public class Art
    {
        public int Id { get; set; }

        public string ImageSource { get; set; }

        public string Title { get; set; }

        public string Medium { get; set; }

        public int Year { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public int Price { get; set; }

        public Collections Collection { get; set; }

        public enum Collections
        {
            Oceans,
            Atmosphere,
            Horizons,
            Abstracts,
            UrbanArt
        }
    }
}
