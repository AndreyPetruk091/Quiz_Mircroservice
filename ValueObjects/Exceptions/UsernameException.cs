using System;

namespace Quiz_Mircroservice.ValueObjects.Exceptions
{
    public class UsernameException : Exception
    {
        public UsernameException(string message) : base(message) { }
        public UsernameException(string message, Exception inner) : base(message, inner) { }
    }
}