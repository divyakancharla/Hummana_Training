using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnAuthorizeAndDependencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongController : ControllerBase
    {
        private readonly SongOriginal _DIO;
        public SongController(SongOriginal _DIO)
        {
            this._DIO = _DIO;
        }
        [HttpGet]
        public IActionResult GetTune()
        {
            ISong song=SongOriginal.SongObject();
            _DIO.PropertyInjection = new SongLyrics();
           return Ok( _DIO.PropertyInjection.MakeATune());
           // return Ok(song.MakeATune());
        }
        [HttpGet]
        [Route("Unity")]
        public IActionResult Unity()
        {
            return Ok(_DIO.check());
        }
    }
}
