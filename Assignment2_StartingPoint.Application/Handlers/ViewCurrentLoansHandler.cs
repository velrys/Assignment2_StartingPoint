using Assignment2_StartingPoint.Domain;
using Assignment2_StartingPoint.Domain.UseCase;
using CommandLineUI.Commands;

namespace Assignment2_StartingPoint.Application.Handlers
{
    public class ViewCurrentLoansHandler : BaseHandler<ViewCurrentLoans_UseCase, ViewCurrentLoansCommand>
    {
        public ViewCurrentLoansHandler(IDatabaseGatewayFacade databaseGatewayFacade) : base(databaseGatewayFacade)
        {

        }
    }
}