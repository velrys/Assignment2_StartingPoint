using Assignment2_StartingPoint.Domain;
using Assignment2_StartingPoint.Domain.UseCase;
using CommandLineUI.Commands;

namespace Assignment2_StartingPoint.Application.Handlers
{
    public class ViewAllMembersHandler : BaseHandler<ViewAllMembers_UseCase, ViewAllMembersCommand>
    {
        public ViewAllMembersHandler(IDatabaseGatewayFacade databaseGatewayFacade) : base(databaseGatewayFacade)
        {

        }
    }
}