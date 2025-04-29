using Domain.Entities;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Repositories.Abstractions
{
    public interface IParticipantRepository : IRepository<Participant>
    {
        Task<Participant?> GetParticipantByUsernameAsync(string username, CancellationToken cancellationToken);
    }
}