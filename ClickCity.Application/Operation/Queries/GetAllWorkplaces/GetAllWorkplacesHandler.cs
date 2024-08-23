using ClickCity.Application.Common.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickCity.Application.Operation.Queries.GetAllWorkplaces
{
    public class GetAllWorkplacesHandler : IQueryHandler<GetAllWorkplacesQuery, GetAllWorkplacesResponse>
    {
        public async Task<GetAllWorkplacesResponse> Handle(GetAllWorkplacesQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}