using ValueObjects.Exceptions;
using ValueObjects.Base;

namespace ValueObjects
{
    public class AnswerIndex : ValueObject
    {
        public int Value { get; }

        public AnswerIndex(int value)
        {
            if (value < 0)
                throw new AnswerIndexException("������ �� ����� ���� �������������");

            Value = value;
        }

       
        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Value;
        }

        
        public static implicit operator int(AnswerIndex index) => index.Value;
        public static explicit operator AnswerIndex(int value) => new(value);
        public override string ToString() => Value.ToString();
    }
}