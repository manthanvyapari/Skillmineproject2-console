using System;
using System.Runtime.Serialization;

namespace Skillmineproject2.Collection
{
    [Serializable]
    internal class MarksException : Exception
    {
        public MarksException()
        {
        }

        public MarksException(string message) : base(message)
        {
        }

        public MarksException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MarksException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}