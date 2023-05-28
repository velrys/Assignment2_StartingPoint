using Assignment2_StartingPoint.Domain.DTOs;
using MediatR;

namespace CommandLineUI.Commands
{
    public class ViewAllBooksCommand : IRequest<IDto>
    {
        public ViewAllBooksCommand()
        {
        }        
    }
}
