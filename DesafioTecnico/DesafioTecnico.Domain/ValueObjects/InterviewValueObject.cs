using System;

namespace DesafioTecnico.Domain.ValueObjects
{
    public class InterviewValueObject
    {
        public string Notes { get; set; }
        public Guid JobOpportunityId { get; set; }
        public Guid CandidateId { get; set; }
    }
}