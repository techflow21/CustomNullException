
namespace CustomNullException
{
    public class CustomNullException : Exception
    {
        public CustomNullException()
        {
        }
        public CustomNullException(string message) : base(message)
        {
        }
        public CustomNullException(string message, Exception innerexception) : base(message, innerexception)
        {
        }
    }
}
