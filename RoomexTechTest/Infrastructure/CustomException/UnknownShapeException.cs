using System.Runtime.Serialization;

namespace RoomexTechTestApi.Infrastructure.CustomException
{
    [Serializable]
    public class UnknownShapeException : Exception
    {
        public UnknownShapeException(string body)
        {
            Body = body;
        }

        public UnknownShapeException(string body, string? message) : base(message)
        {
            Body = body;
        }

        public UnknownShapeException(string body, string? message, Exception? innerException) : base(message, innerException)
        {
            Body = body;
        }

        protected UnknownShapeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            Body = info.GetString(nameof(Body));
        }

        /// <summary>
        /// Get the unsupported body string representation.
        /// </summary>
        public string Body { get; private set; }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue(nameof(Body), Body);
            base.GetObjectData(info, context);
        }
    }
}
