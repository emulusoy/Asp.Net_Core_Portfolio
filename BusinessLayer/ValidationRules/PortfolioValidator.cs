using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class PortfolioValidator:AbstractValidator<Portfolio>
    {
        public PortfolioValidator() {
            RuleFor(x => x.PortfolioName)
            .NotEmpty().WithMessage("Project Name is required.")
            .MaximumLength(100).WithMessage("Project Name cannot exceed 100 characters.")
            .MinimumLength(5).WithMessage("Project Name cannot be less than 5 characters.");

            //RuleFor(x => x.PortfolioImageUrl)
            //    .NotEmpty().WithMessage("Project Name is required.")
            //.MaximumLength(100).WithMessage("Project Name cannot exceed 100 characters.")
            //.MinimumLength(5).WithMessage("Project Name cannot be less than 5 characters.");

            RuleFor(x => x.PortfolioImageUrl2)
                .NotEmpty().WithMessage("Project Name is required.")
            .MaximumLength(100).WithMessage("Project Name cannot exceed 100 characters.")
            .MinimumLength(5).WithMessage("Project Name cannot be less than 5 characters.");

            RuleFor(x => x.PortfolioProjectUrl)
                .NotEmpty().WithMessage("Project Name is required.")
            .MaximumLength(100).WithMessage("Project Name cannot exceed 100 characters.")
            .MinimumLength(5).WithMessage("Project Name cannot be less than 5 characters.");
        }
    }
}
