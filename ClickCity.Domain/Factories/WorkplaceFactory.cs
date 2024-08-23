using ClickCity.Domain.Entities;
using System.Collections.ObjectModel;

namespace ClickCity.Domain.Factories
{
    public static class WorkplaceFactory
    {
        public static Workplace Create(
            string name,
            string? description,
            ICollection<WorkplaceLevel> levels) => new(
                id: Guid.NewGuid(),
                name: name,
                description: description,
                levels: levels);

        public static Workplace CreateWithoutLevels(
            string name,
            string? description) => new(
                id: Guid.NewGuid(),
                name: name,
                description: description,
                levels: []);
    }
}