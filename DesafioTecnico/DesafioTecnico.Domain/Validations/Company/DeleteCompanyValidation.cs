namespace DesafioTecnico.Domain.Validations.Company
{
    public class DeleteCompanyValidation : CompanyValidation<Models.Company>
    {
        public DeleteCompanyValidation()
        {
            ValidateId();
        }
    }
}