using ClickCity.Application.Common.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickCity.Application.Operation.Commands.CreateWorksplace
{
    public record CreateWorkplaceCommand(string Name, string? Description) : ICommand<CreateWorkplaceResponse>;
}