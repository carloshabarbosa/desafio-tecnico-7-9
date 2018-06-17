using System;
using FluentValidation;

namespace DesafioTecnico.Domain.Validations.Candidate
{
    public class CandidateValidation<T> : AbstractValidator<T> where T :Models.Candidate 
    {
        protected void ValidateName()
        {
            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("Please ensure you have entered the Name")
                .Length(2, 70).WithMessage("The Name must have between 2 and 70 characters");
        }
        
        protected void ValidateCpf()
        {
            RuleFor(c => c.Cpf)
                .NotEmpty().WithMessage("Please ensure you have entered the Cpf");
        }
        
        protected void ValidateAddress()
        {
            RuleFor(c => c.Address)
                .NotEmpty().WithMessage("Please ensure you have entered the Address");
        }
        
        protected void ValidatePhone()
        {
            RuleFor(c => c.Phone)
                .NotEmpty().WithMessage("Please ensure you have entered the Phone");
        }
        
        protected void ValidateId()
        {
            RuleFor(c => c.Id)
                .NotEqual(Guid.Empty);
        }
    }
}