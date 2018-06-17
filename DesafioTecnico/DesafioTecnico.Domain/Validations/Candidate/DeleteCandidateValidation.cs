namespace DesafioTecnico.Domain.Validations.Candidate
{
    public class DeleteCandidateValidation : CandidateValidation<Models.Candidate>
    {
        public DeleteCandidateValidation()
        {
            ValidateId();
        }
    }
}