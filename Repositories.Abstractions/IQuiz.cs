﻿using Domain;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Repositories.Abstractions
{
    public interface IQuizRepository : IRepository<Quiz>
    {

        Task<Quiz?> GetQuizWithQuestionsAsync(Guid quizId, CancellationToken cancellationToken);

        
        Task<IEnumerable<Quiz>> GetByNameAsync(string name, CancellationToken cancellationToken);

      
        Task<IEnumerable<Quiz>> GetByStatusAsync(string status, CancellationToken cancellationToken);

        
        Task<IEnumerable<Quiz>> GetActiveQuizzesAsync(int skip, int take, CancellationToken cancellationToken);

        
        Task<bool> ExistsByNameAsync(string name, CancellationToken cancellationToken);

       
        Task UpdateNameAsync(Guid quizId, string newName, CancellationToken cancellationToken);

      
        Task<IEnumerable<Quiz>> GetByCategoryAsync(string category, CancellationToken cancellationToken);

      
        Task SoftDeleteAsync(Guid quizId, CancellationToken cancellationToken);
        Task AddAsync(Domain.Entities.Quiz quiz, CancellationToken ct);
    }
}