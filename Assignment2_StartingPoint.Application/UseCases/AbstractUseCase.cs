using Assignment2_StartingPoint.Domain.DTOs;

namespace Assignment2_StartingPoint.Domain
{
    public abstract class AbstractUseCase
    {
        protected readonly IDatabaseGatewayFacade gatewayFacade;

        public AbstractUseCase(IDatabaseGatewayFacade gatewayFacade)
        {
            this.gatewayFacade = gatewayFacade;
        }

        public abstract IDto Execute();
    }
}
