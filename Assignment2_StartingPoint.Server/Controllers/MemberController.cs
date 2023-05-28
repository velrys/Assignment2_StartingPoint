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
    public class MemberController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MemberController(IMediator _mediator)
        {
            this._mediator = _mediator ?? throw new ArgumentNullException();
        }

        [HttpGet("All")]
        [ProducesResponseType(typeof(MemberDTO_List), 200)]
        public async Task<IActionResult> AllMembers()
        {
            var request = new ViewAllMembersCommand();
            var books = await _mediator.Send(request);

            return Ok(books);
        }
    }
}
