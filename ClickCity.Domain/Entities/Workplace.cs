using ClickCity.Domain.Common;
using ClickCity.Domain.Entities.Validators;
using FluentValidation;

namespace ClickCity.Domain.Entities
{
    public class Workplace : EntityBase
    {
        public Workplace(
            Guid id,
            string name,
            string? description,
            ICollection<WorkplaceLevel> levels) : base(id)
        {
            Name=name;
            Description=description;
            Levels=levels;

            Validate();
        }

        public string Name { get; set; }
        public string? Description { get; private set; }
        public ICollection<WorkplaceLevel> Levels { get; private set; }

        protected override void Validate() => new WorkplaceValidator().ValidateAndThrow(this);
    }
}