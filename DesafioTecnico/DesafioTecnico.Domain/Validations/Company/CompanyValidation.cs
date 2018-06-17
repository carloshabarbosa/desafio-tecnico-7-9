using System;
using FluentValidation;

namespace DesafioTecnico.Domain.Validations.Company
{
    public abstract class CompanyValidation<T> : AbstractValidator<T> where T :Models.Company 
    {
        protected void ValidateName()
        {
            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("Please ensure you have entered the Name")
                .Length(2, 50).WithMessage("The Name must have between 2 and 50 characters");
        }
        
        protected void ValidateAddress()
        {
            RuleFor(c => c.Address)
                .NotEmpty().WithMessage("Please ensure you have entered the Address")
                .Length(2, 70).WithMessage("The Adrress must have between 2 and 70 characters");
        }

        protected void ValidatePhone()
        {
            RuleFor(c => c.Phone)
                .NotEmpty().WithMessage("Please ensure you have entered the phone")
                .MinimumLength(7).WithMessage("The Phone must have between 7 characters");
        }
        
        protected void ValidateCnpj()
        {
            RuleFor(c => c.Cnpj)
                .NotEmpty().WithMessage("Please ensure you have entered the CNPJ")
                .MinimumLength(7).WithMessage("The CNPJ must have more than 7");
        }
        
        protected void ValidateId()
        {
            RuleFor(c => c.Id)
                .NotEqual(Guid.Empty);
        }
    }
}