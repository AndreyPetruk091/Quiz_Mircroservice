using Domain.Entities.Base;
using ValueObjects;
using Domain.Exceptions;

namespace Domain.Entities
{
    public class Participant : EntityBase
    {
        public Username Username { get; private set; }

        public Participant(Username username)
        {
            Username = username ?? throw new UsernameException("Username cannot be null.");
        }

        public void UpdateUsername(Username newUsername)
        {
            Username = newUsername ?? throw new UsernameException("Username cannot be null.");
        }
    }
}