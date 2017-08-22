using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Authentication.Infrastructure.Exceptions
{
    public class GameSparksRequestException : Exception
    {
        public GameSparksRequestException()
        { }

        public GameSparksRequestException(string message)
            : base(message)
        { }

        public GameSparksRequestException(string message, Exception inner)
            : base(message, inner)
        { }
    }
}
