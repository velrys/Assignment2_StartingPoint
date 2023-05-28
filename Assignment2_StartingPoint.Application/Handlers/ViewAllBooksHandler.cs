using Assignment2_StartingPoint.Domain;
using Assignment2_StartingPoint.Domain.UseCase;
using CommandLineUI.Commands;

namespace Assignment2_StartingPoint.Application.Handlers
{
    public class ViewAllBooksHandler : BaseHandler<ViewAllBooks_UseCase, ViewAllBooksCommand>                                      
    {
        public ViewAllBooksHandler(IDatabaseGatewayFacade databaseGatewayFacade) : base(databaseGatewayFacade)
        {
                
        }
    }
}