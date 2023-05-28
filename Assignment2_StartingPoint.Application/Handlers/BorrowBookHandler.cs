using Assignment2_StartingPoint.Domain;
using Assignment2_StartingPoint.Domain.UseCase;
using CommandLineUI.Commands;

namespace Assignment2_StartingPoint.Application.Handlers
{
    public class BorrowBookHandler : BaseHandler<BorrowBook_UseCase, BorrowBookCommand>
    {
        public BorrowBookHandler(IDatabaseGatewayFacade databaseGatewayFacade) : base(databaseGatewayFacade)
        {

        }

        public override BorrowBook_UseCase CreateUseCase(BorrowBookCommand request)
        {
            return new BorrowBook_UseCase(request.MemberID, request.BookID, gatewayFacade);
        }
    }
}