using ValueObjects.Exceptions;
using Domain.Entities;
using ValueObjects.Base;

namespace ValueObjects.Validators
{
    public class QuestionValidator : IValidator<Question>
    {
        public void Validate(Question question)
        {
            if (string.IsNullOrWhiteSpace(question.Text))
                throw new ValidationException("Question text cannot be empty.");

            if (question.Answers == null || !question.Answers.Any())
                throw new ValidationException("Answers cannot be empty.");

        }
    }
}