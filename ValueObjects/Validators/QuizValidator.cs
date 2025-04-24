using QuizMicroservice.Domain.Domain.Entities;
using QuizMicroservice.Domain.Domain.ValueObjects.Base;
using QuizMicroservice.Domain.Domain.ValueObjects.Exceptions;
using System;

namespace QuizMicroservice.Domain.Domain.ValueObjects.Validators
{
    public class QuizValidator : IValidator<Quiz>
    {
        public void Validate(Quiz quiz)
        {
            
            if (string.IsNullOrWhiteSpace(quiz.Title))
                throw new ValidationException("Quiz title cannot be empty.");

           

   
            if (quiz.Questions == null || !quiz.Questions.Any())
                throw new ValidationException("Quiz must contain at least one question.");

            foreach (var question in quiz.Questions)
            {
                if (question == null)
                    throw new ValidationException("Quiz cannot contain null questions.");
            }

       

          
        }
    }
}