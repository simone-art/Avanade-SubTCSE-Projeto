using FluentValidation;
using Avanade.SubTCSE.Projeto.Domain.Aggregates.EmployeeRole.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Domain.Aggregates.Employee.Validators
{
    public class EmployeeValidator : AbstractValidator<Entities.Employee>
    {
        public EmployeeValidator()
        {
            RuleSet("new", () =>
            {
                RuleFor(e => e.FirstName)
                 .NotEmpty()
                 .WithMessage("{PropertyName} can not be empty");

                RuleFor(e => e.SecondName)
                .NotEmpty()
                .WithMessage("{PropertyName} can not be empty");

                //RuleFor(e => e.EmployeeRole)
                //.SetValidator(new EmployeeRoleValidator());

            });
        }
    }
}
