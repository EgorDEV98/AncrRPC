namespace AncrRPC.Exception
{
    public class AncrException : System.Exception
    {
        public int Code { get; init; }
        
        public AncrException(string message, int code) 
            : base(message)
        {
            Code = code;
        }
        
        public AncrException(string message) 
            : base(message)
        { }
    }
}