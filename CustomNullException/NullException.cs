
namespace CustomNullException
{
    public class CustomNullException : Exception
    {
        public CustomNullException()
        {
        }
        public CustomNullException(string text) : base(text)
        {
        }
        public CustomNullException(string text, Exception innerexception) : base(text, innerexception)
        {
        }
    }
}
