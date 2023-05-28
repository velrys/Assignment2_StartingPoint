using Assignment2_StartingPoint.Domain.DTOs;
using MediatR;

namespace CommandLineUI.Commands
{
    public class RenewLoanCommand : OperationBook, IRequest<IDto>
    {        
        public RenewLoanCommand()
        {
        }        
    }
}

