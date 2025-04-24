using Quiz_Mircroservice.Domain.Entities;
using Quiz_Mircroservice.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Quiz_Mircroservice.Repositories.Abstractions
{
    public interface IQuizRepository : IRepository<Quiz>
    {

        Task<Quiz?> GetQuizWithQuestionsAsync(Guid quizId, CancellationToken cancellationToken);

        // Поиск викторин по названию
        Task<IEnumerable<Quiz>> GetByNameAsync(string name, CancellationToken cancellationToken);

        // Получение викторин по статусу (например, "активный", "архивный")
        Task<IEnumerable<Quiz>> GetByStatusAsync(string status, CancellationToken cancellationToken);

        // Получение активных викторин с пагинацией
        Task<IEnumerable<Quiz>> GetActiveQuizzesAsync(int skip, int take, CancellationToken cancellationToken);

        // Проверка существования викторины по имени
        Task<bool> ExistsByNameAsync(string name, CancellationToken cancellationToken);

        // Обновление только названия викторины
        Task UpdateNameAsync(Guid quizId, string newName, CancellationToken cancellationToken);

        // Получение викторин по категории
        Task<IEnumerable<Quiz>> GetByCategoryAsync(string category, CancellationToken cancellationToken);

        // Мягкое удаление викторины
        Task SoftDeleteAsync(Guid quizId, CancellationToken cancellationToken);

    }
}