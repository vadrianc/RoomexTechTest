using System.Runtime.Serialization;

namespace RoomexTechTestApi.Infrastructure.CustomException
{
    [SerializableAttribute]
    public class BodyShapeException : Exception
    {
        public BodyShapeException(string body)
        {
            Body = body;
        }

        public BodyShapeException(string body, string? message) : base(message)
        {
            Body = body;
        }

        public BodyShapeException(string body, string? message, Exception? innerException) : base(message, innerException)
        {
            Body = body;
        }

        protected BodyShapeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            Body = info.GetString(nameof(Body));
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue(nameof(Body), Body);
            base.GetObjectData(info, context);
            
        }

        /// <summary>
        /// Get the unsupported body string representation.
        /// </summary>
        public string Body { get; private set; }
    }
}
