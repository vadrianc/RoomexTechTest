using System.Runtime.Serialization;

namespace RoomexTechTestApi.Infrastructure.CustomException
{
    [Serializable]
    public class UnknownCalculatorException : Exception
    {
        public UnknownCalculatorException(string method)
        {
            Method = method;
        }

        public UnknownCalculatorException(string method, string? message) : base(message)
        {
            Method = method;
        }

        public UnknownCalculatorException(string method, string? message, Exception? innerException) : base(message, innerException)
        {
            Method = method;
        }

        protected UnknownCalculatorException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            Method = info.GetString(nameof(Method));
        }

        /// <summary>
        /// Get the unsupported body string representation.
        /// </summary>
        public string Method { get; private set; }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue(nameof(Method), Method);
            base.GetObjectData(info, context);
        }
    }
}
