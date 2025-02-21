using System;

namespace UserValidationApp
{
    public class InvalidUsernameException : Exception
    {
        public InvalidUsernameException(string message) : base(message) { }
    }
}
