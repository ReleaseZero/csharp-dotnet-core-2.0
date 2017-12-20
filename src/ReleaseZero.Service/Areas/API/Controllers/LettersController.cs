using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ReleaseZero.Service.Areas.API.Models;

namespace ReleaseZero.Service.Areas.API.Controllers
{
    /// <summary>
    /// Letters controller
    /// </summary>
    [Area("API")]
    [Route("api/letters")]
    public class LettersController : Controller
    {
        private readonly ILogger<LettersController> _logger;
        
        /// <summary>
        /// Constructor for LettersController
        /// </summary>
        /// <param name="logger"></param>
        public LettersController(ILogger<LettersController> logger)
        {
            _logger = logger;
        }

        /// <summary>
		/// Gets all letter instances (NATO Phonetic alphabet)
		/// </summary>
		/// <returns>All letter instances</returns>
		/// <response code="200">All letter instances</response>
		/// <response code="404">There are no letter instances available</response>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Letter>), 200)]
        [ProducesResponseType(typeof(void), 404)]
        public async Task<IActionResult> GetAllLetters()
        {
            return Ok("value");
        }
    }
}