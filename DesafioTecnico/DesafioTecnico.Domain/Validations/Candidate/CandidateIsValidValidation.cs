namespace DesafioTecnico.Domain.Validations.Candidate
{
    public class CandidateIsValidValidation : CandidateValidation<Models.Candidate>
    {
        public CandidateIsValidValidation()
        {
            ValidateAddress();
            ValidateName();
            ValidateCpf();
            ValidatePhone();
        }
    }
}