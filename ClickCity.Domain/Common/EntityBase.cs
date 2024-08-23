using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickCity.Domain.Common
{
    public abstract class EntityBase(Guid id)
    {
        public Guid Id { get; init; } = id;

        protected abstract void Validate();
    }
}