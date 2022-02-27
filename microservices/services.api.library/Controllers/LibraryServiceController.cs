using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using services.api.library.Core.Entities;
using services.api.library.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace services.api.library.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryServiceController : ControllerBase
    {
        private readonly IAutorRepository _autorRepository;

        public LibraryServiceController(IAutorRepository autorRepository)
        {
            _autorRepository = autorRepository;
        }
        [HttpGet("autores")]
        public async Task<ActionResult<IEnumerable<Autor>>> GetAutores()
        {
            var autores = await _autorRepository.GetAutores();
            return Ok(autores);
        }
    }
}
