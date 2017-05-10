using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Infrastructure.Exceptions
{
    public class GameSparksForbiddenException : Exception
    {
        public GameSparksForbiddenException()
        { }

        public GameSparksForbiddenException(string message)
            : base(message)
        { }

        public GameSparksForbiddenException(string message, Exception inner)
            : base(message, inner)
        { }
    }
}
