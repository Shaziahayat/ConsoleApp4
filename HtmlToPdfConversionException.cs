using System;
using System.Runtime.Serialization;

namespace ConsoleApp4
{
    [Serializable]
    internal class HtmlToPdfConversionException : Exception
    {
        public HtmlToPdfConversionException()
        {
        }

        public HtmlToPdfConversionException(string message) : base(message)
        {
        }

        public HtmlToPdfConversionException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected HtmlToPdfConversionException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}