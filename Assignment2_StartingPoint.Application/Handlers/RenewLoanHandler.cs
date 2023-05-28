using Assignment2_StartingPoint.Domain;
using Assignment2_StartingPoint.Domain.UseCase;
using CommandLineUI.Commands;

namespace Assignment2_StartingPoint.Application.Handlers
{
    public class RenewLoanHandler : BaseHandler<RenewLoan_UseCase, RenewLoanCommand>
    {
        public RenewLoanHandler(IDatabaseGatewayFacade databaseGatewayFacade) : base(databaseGatewayFacade)
        {

        }

        public override RenewLoan_UseCase CreateUseCase(RenewLoanCommand request)
        {
            return new RenewLoan_UseCase(request.MemberID, request.BookID, gatewayFacade);
        }
    }    
}