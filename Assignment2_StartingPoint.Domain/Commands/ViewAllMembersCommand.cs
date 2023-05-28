using Assignment2_StartingPoint.Domain.DTOs;
using MediatR;

namespace CommandLineUI.Commands
{
    public class ViewAllMembersCommand : IRequest<IDto>
    {
        public ViewAllMembersCommand()
        {
        }       
    }
}