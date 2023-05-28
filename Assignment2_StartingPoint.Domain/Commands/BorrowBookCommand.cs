using Assignment2_StartingPoint.Domain.DTOs;
using MediatR;

namespace CommandLineUI.Commands
{
    public class BorrowBookCommand : OperationBook, IRequest<IDto>
    {        
        public BorrowBookCommand()
        {
        }        
    }
}
