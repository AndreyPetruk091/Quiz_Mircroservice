using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Mircroservice.Domain.Exceptions
{
    public class QuizException : DomainException
    {
        public QuizException(string message) : base(message)
        {
        }
    }
}
