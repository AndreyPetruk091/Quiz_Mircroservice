using Quiz_Mircroservice.ValueObjects.Exceptions;
using Quiz_Mircroservice.ValueObjects.Base;

namespace Quiz_Mircroservice.ValueObjects
{
    public class QuestionText : ValueObject
    {
        public string Value { get; }
        private const int MaxLength = 500;

        public QuestionText(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new QuestionTextException(ExceptionMessages.EmptyQuestionText);
            
            if (value.Length > MaxLength)
                throw new QuestionTextException(
                    ExceptionMessages.Format(ExceptionMessages.QuestionTextTooLong, MaxLength));

            Value = value;
        }

        protected override IEnumerable<object> GetAtomicValues() => new[] { Value };
        public static implicit operator string(QuestionText text) => text.Value;
    }
}