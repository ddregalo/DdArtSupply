namespace DdArtSupply.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using DdArtSupply.Repositories;
    using Microsoft.AspNetCore.Mvc;

    public class ArtController : Controller
    {
        private readonly IArtRepository artRepository;

        public ArtController(IArtRepository artRepository)
        {
            this.artRepository = artRepository;

        }

        // GET: /<controller>/
        public ViewResult List()
        {
            return View(artRepository.Artworks);
        }
    }
}
