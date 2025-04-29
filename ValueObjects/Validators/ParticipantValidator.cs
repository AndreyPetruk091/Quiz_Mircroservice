using Domain.Entities;
using ValueObjects.Base;
using ValueObjects.Exceptions;

namespace   ValueObjects.Validators
{
    public class ParticipantValidator : IValidator<Participant>
    {
        public void Validate(Participant participant)
        {
            if (string.IsNullOrWhiteSpace(participant.Username))
                throw new ValidationException("Username cannot be empty.");
        }
    }
}