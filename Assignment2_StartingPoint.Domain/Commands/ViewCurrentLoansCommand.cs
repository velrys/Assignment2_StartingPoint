using Assignment2_StartingPoint.Domain.DTOs;
using MediatR;

namespace CommandLineUI.Commands
{
    public class ViewCurrentLoansCommand : IRequest<IDto>
    {
        public ViewCurrentLoansCommand()
        {
        }                
    }
}
