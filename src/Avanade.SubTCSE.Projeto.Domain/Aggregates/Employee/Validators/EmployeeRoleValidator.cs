using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Domain.Aggregates.Employee.Validators
{
    public class EmployeeRoleValidator : AbstractValidator<Entities.EmployeeRole>
    {
        public EmployeeRoleValidator()
        {
            //Ruleset seta regras
            RuleSet("new", () =>
            {
                RuleFor(e => e.RoleName)
                  .NotEmpty()
                  .WithMessage("{PropertyName} can not be empty");
            });
        }
    }
}
