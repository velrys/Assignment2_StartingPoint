using Assignment2_StartingPoint.Domain;
using Assignment2_StartingPoint.Domain.UseCase;
using CommandLineUI.Commands;

namespace Assignment2_StartingPoint.Application.Handlers
{
    public class ReturnBookLoansHandler : BaseHandler<ReturnBook_UseCase, ReturnBookCommand>
    {
        public ReturnBookLoansHandler(IDatabaseGatewayFacade databaseGatewayFacade) : base(databaseGatewayFacade)
        {

        }

        public override ReturnBook_UseCase CreateUseCase(ReturnBookCommand request)
        {
            return new ReturnBook_UseCase(request.MemberID, request.BookID, gatewayFacade);
        }
    }
}