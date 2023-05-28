using Assignment2_StartingPoint.Domain;
using Assignment2_StartingPoint.Domain.DTOs;
using MediatR;

namespace Assignment2_StartingPoint.Application.Handlers
{
    public abstract class BaseHandler<TUseCase, TRequest> : IRequestHandler<TRequest, IDto>
        where TRequest : IRequest<IDto>
        where TUseCase : AbstractUseCase
    {
        protected readonly IDatabaseGatewayFacade gatewayFacade;

        protected BaseHandler(IDatabaseGatewayFacade databaseGatewayFacade)
        {
            gatewayFacade = databaseGatewayFacade;
        }

        public virtual TUseCase CreateUseCase(TRequest request)
        {
            dynamic useCase = Activator.CreateInstance(typeof(TUseCase), gatewayFacade);

            return useCase;
        }

        public async Task<IDto> Handle(TRequest request, CancellationToken cancellationToken)
        {            
            if (gatewayFacade != null)
            {                
                IDto dto = CreateUseCase(request)?.Execute();
                
                return await Task.FromResult(dto);
            }

            return null;
        }
    }
}