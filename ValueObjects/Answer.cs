using ValueObjects.Base;
using ValueObjects.Exceptions;

namespace ValueObjects
{
    public class Answer : ValueObject
    {
        public string Value { get; }

        public Answer(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new AnswerException(ExceptionMessages.EmptyAnswer);

            Value = value;
        }

        protected override IEnumerable<object> GetAtomicValues() => new[] { Value };
        public static implicit operator string(Answer answer) => answer.Value;
    }
}