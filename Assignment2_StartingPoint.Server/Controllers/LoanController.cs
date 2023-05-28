using Assignment2_StartingPoint.Domain.DTOs;
using CommandLineUI.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Assignment2_StartingPoint.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    [Consumes("application/json")]
    public class LoanController : ControllerBase
    {
        private readonly IMediator _mediator;

        public LoanController(IMediator _mediator)
        {
            this._mediator = _mediator ?? throw new ArgumentNullException();
        }

        [HttpGet("Current")]        
        public async Task<IEnumerable<LoanViewtDTO>> Current()
        {
            var request = new ViewCurrentLoansCommand();
            var currents = (LoanDTO_List)await _mediator.Send(request);

            return currents.List.Select(x=> new LoanViewtDTO(x));            
        }

        [HttpPost("Renew")]
        [ProducesResponseType(typeof(MessageDTO), 200)]
        public async Task<IActionResult> Renew([FromBody]RenewLoanCommand request) 
        {            
            var msg = await _mediator.Send(request);

            return Ok(msg);
        }

        [HttpPost("Borrow")]
        [ProducesResponseType(typeof(MessageDTO), 200)]
        public async Task<IActionResult> Borrow([FromBody] BorrowBookCommand request)
        {
            var msg = await _mediator.Send(request);

            return Ok(msg);
        }

        [HttpPost("Return")]
        [ProducesResponseType(typeof(MessageDTO), 200)]
        public async Task<IActionResult> Return([FromBody] ReturnBookCommand request)
        {
            var msg = await _mediator.Send(request);

            return Ok(msg);
        }
    }
}
