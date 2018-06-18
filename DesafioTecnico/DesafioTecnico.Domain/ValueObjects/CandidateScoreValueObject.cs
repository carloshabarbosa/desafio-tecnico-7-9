using System;

namespace DesafioTecnico.Domain.ValueObjects
{
    public class CandidateScoreValueObject
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }
    }
}