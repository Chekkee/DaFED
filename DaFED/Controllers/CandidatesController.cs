using DaFED.Models;
using DaFED.Services;
using Microsoft.AspNetCore.Mvc;

namespace DaFED.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CandidatesController : ControllerBase
    {
        private readonly ICandidateService _candidateService;

        public CandidatesController(ICandidateService candidateService)
        {
            _candidateService = candidateService;    
        }

        [HttpGet]
        [Route("GoodCandidates")]
        public IActionResult GetGoodCandidates()
        {
            return Ok(_candidateService.GetGoodCandidates());
        }

        [HttpGet]
        [Route("DecentCandidates")]
        public IActionResult GetDecentCandidates() 
        {
            return Ok(_candidateService.GetDecentCandidates());
        }

        [HttpGet]
        [Route("BadCandidates")]
        public IActionResult GetBadCandidates()
        {
            return Ok(_candidateService.GetBadCandidates());
        }

        [HttpGet]
        [Route("YoungerThen/{age}")]
        public IActionResult GetYoungerCandidates([FromRoute] int age) 
        {
            return Ok(_candidateService.GetCandidatesYoungerThen(age));
        }

        [HttpPost]
        public IActionResult InsertNewCandidate([FromBody] InsertNewCandidateDTO newCandidate)
        {
            try
            {
                _candidateService.InsertNewCandidate(newCandidate);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
            
            return Ok();
        }
    }
}
