namespace DesafioTecnico.Domain.Validations.Company
{
    public class CompanyIsValidValidation : CompanyValidation<Models.Company>
    {
        public CompanyIsValidValidation()
        {
            ValidateAddress();
            ValidateCnpj();
            ValidateName();
            ValidatePhone();
        }
    }
}