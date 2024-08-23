using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickCity.Domain.Common
{
    public interface IEvent
    {
        DateTime OccuredOn { get; }
    }
}
