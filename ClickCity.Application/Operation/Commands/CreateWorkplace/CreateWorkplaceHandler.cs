using ClickCity.Application.Common.Commands;
using ClickCity.Domain.Factories;
using ClickCity.Domain.Repository;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickCity.Application.Operation.Commands.CreateWorksplace
{
    public class CreateWorkplaceHandler : ICommandHandler<CreateWorkplaceCommand, CreateWorkplaceResponse>
    {
        private readonly ILogger<CreateWorkplaceHandler> _logger;
        private readonly IWorkplaceRepository _workplaceRepository;

        public CreateWorkplaceHandler(ILogger<CreateWorkplaceHandler> logger, IWorkplaceRepository workplaceRepository)
        {
            _logger=logger;
            _workplaceRepository=workplaceRepository;
        }

        public async Task<CreateWorkplaceResponse> Handle(CreateWorkplaceCommand request, CancellationToken cancellationToken)
        {
            var workplace = WorkplaceFactory.CreateWithoutLevels(request.Name, request.Description);

            await _workplaceRepository.CreateAsync(workplace, cancellationToken);

            return new CreateWorkplaceResponse(workplace);
        }
    }
}