using Assignment2_StartingPoint.Domain.DTOs;
using MediatR;

namespace CommandLineUI.Commands
{
    public class ReturnBookCommand : OperationBook, IRequest<IDto>
    {        
        public ReturnBookCommand()
        {
        }        
    }
}