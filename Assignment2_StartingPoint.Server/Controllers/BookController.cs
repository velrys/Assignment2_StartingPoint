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
    public class BookController : ControllerBase
    {        
        private readonly IMediator _mediator;

        public BookController(IMediator _mediator)
        {
            this._mediator = _mediator ?? throw new ArgumentNullException();
        }

        [HttpGet("All")]   
        [ProducesResponseType(typeof(BookDTO_List), 200)]
        public async Task<IActionResult> All()
        {
            var request = new ViewAllBooksCommand();
            var books = await _mediator.Send(request);

            return Ok(books);    
        }               
    }
}