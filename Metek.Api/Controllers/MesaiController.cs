using Metek.Application.Features.Mesai.Commands.Create;
using Metek.Application.Features.Mesai.Commands.Delete;
using Metek.Application.Features.Mesai.Commands.Update;
using Metek.Application.Features.Mesai.Queries.GetList;
using Metek.Application.Features.Mesai.Queries.GetShift;
using Metek.Application.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Metek.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MesaiController : BaseController
    {


        private readonly ILogger<MesaiController> _logger;

        public MesaiController(ILogger<MesaiController> logger, ShiftCalculatorService shiftCalculatorService)
        {
            _logger = logger;
        }

        
        [HttpGet("GetHakedis")]
        public async Task<IActionResult> GetHakedis()
        {
             var result = await Mediator.Send(new GetShiftListQuery());
            return Ok(result);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList()
        {
            var result = await Mediator.Send(new GetMesaiListQuery());
            return Ok(result);
        }
       
        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromBody] CreateMesaiCommand request)
        {
            if (request == null)
            {
                return BadRequest("Mesai cannot be null.");
            }
            var result = await Mediator.Send(request);
            return Ok(result);
        }
       
        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateMesaiCommand request)
        {
            if (request == null)
            {
                return BadRequest("Mesai cannot be null.");
            }

            try
            {
                
                var result = await Mediator.Send(request);

                return Ok(result);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteMesaiCommand request)
        {
            if (request == null)
            {
                return BadRequest("Mesai cannot be null.");
            }
            var result = await Mediator.Send(request);

            return Ok(result);
        }

       
       
    }
}
