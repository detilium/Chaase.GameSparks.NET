using System;
using System.Collections.Generic;
using System.Text;

namespace GameSparks.NET.Authentication.Infrastructure.Exceptions
{
    public class GameSparksSettingsException : Exception
    {
        public GameSparksSettingsException()
        { }

        public GameSparksSettingsException(string message)
            : base(message)
        { }

        public GameSparksSettingsException(string message, Exception inner)
            : base(message, inner)
        { }
    }
}
