using ClickCity.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using ClickCity.Domain.Entities.Validators;
using FluentValidation;

namespace ClickCity.Domain.Entities
{
    public class WorkplaceLevel : EntityBase
    {
        public WorkplaceLevel(
            Guid id,
            string name,
            string? description,
            long price,
            Guid? next,
            int maxUnits,
            long coinPerUnit) : base(id)
        {
            Name=name;
            Description=description;
            Price=price;
            Next=next;
            MaxUnits=maxUnits;
            CoinPerUnit=coinPerUnit;

            Validate();
        }

        public string Name { get; private set; }
        public string? Description { get; private set; }
        public long Price { get; private set; }
        public Guid? Next { get; private set; }
        public int MaxUnits { get; private set; }
        public long CoinPerUnit { get; private set; }

        protected override void Validate() => new WorkplaceLevelValidator().ValidateAndThrow(this);
    }
}