using QuizMicroservice.Domain.Domain.ValueObjects.Base;
using QuizMicroservice.Domain.Domain.ValueObjects.Exceptions;
using System.Text.RegularExpressions;

namespace QuizMicroservice.Domain.Domain.ValueObjects.Validators
{
    public class UsernameValidator : IValidator<string> // Изменен тип параметра
    {
        private const int MinLength = 3;
        private const int MaxLength = 50;
        private const string AllowedCharsPattern = @"^[a-zA-Z0-9_\-\.]+$";

        public void Validate(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new UsernameException("Username cannot be empty");

            if (value.Length < MinLength)
                throw new UsernameException($"Username must be at least {MinLength} characters");

            if (value.Length > MaxLength)
                throw new UsernameException($"Username cannot exceed {MaxLength} characters");

            if (!Regex.IsMatch(value, AllowedCharsPattern))
                throw new UsernameException("Username contains invalid characters");
        }
    }
}