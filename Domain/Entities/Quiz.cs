using Quiz_Mircroservice.Domain.Entities.Base;
using Quiz_Mircroservice.ValueObjects;
using Quiz_Mircroservice.Domain.Enums;
using System.Collections.Generic;
using System.Linq;

namespace Quiz_Mircroservice.Domain.Entities
{
    public class Quiz : EntityBase
    {
        private readonly HashSet<Question> _questions = new(); 
        public QuizTitle Title { get; private set; }
        public IEnumerable<Question> Questions => _questions.AsEnumerable(); 
        public QuizStatus Status { get; private set; }

        public Quiz(QuizTitle title)
        {
            Title = title ?? throw new ArgumentNullException(nameof(title));
            Status = QuizStatus.Active;
        }

        // Добавление вопроса
        public void AddQuestion(Question question)
        {
            if (question == null)
                throw new ArgumentNullException(nameof(question));

            if (Status != QuizStatus.Active)
                throw new InvalidOperationException("Вопросы можно добавлять только в активную викторину");

            _questions.Add(question);
        }

        // Удаление вопроса
        public void RemoveQuestion(Question question)
        {
            if (question == null)
                throw new ArgumentNullException(nameof(question));

            _questions.Remove(question);
        }

        // Методы для управления статусом
        public void CompleteQuiz() => Status = QuizStatus.Active;
        public void ArchiveQuiz() => Status = QuizStatus.Archived;
    }
}