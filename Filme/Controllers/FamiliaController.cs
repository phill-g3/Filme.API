using Filme.Domain.Familia;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Filme.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class FamiliaController : ControllerBase
    {
        private readonly IFamiliaService _familiaService;

        public FamiliaController(IFamiliaService familiaService)
        {
            _familiaService = familiaService;
        }

        [HttpGet]
        public async Task<ActionResult> Get(Guid id)
        {
            return Ok(await _familiaService.Get(id));
        }

        [HttpPost]
        public async Task<ActionResult> Post(Familia familia)
        {
            await _familiaService.Post(familia);
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> Put(Familia familia)
        {
            await _familiaService.Put(familia);
            return Ok();
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(Guid id) 
        { 
            await _familiaService.Delete(id);
            return Ok();
        }
    }
}
