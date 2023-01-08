using AncrRPC.Interfaces;
using Newtonsoft.Json;

namespace AncrRPC.Errors
{
    public class ErrorBase : IResponse
    {
        public string jsonrpc { get; set; }
        public int id { get; set; }
        public Error error { get; set; }
    }
    public class Error
    {
        [JsonProperty("code")]
        public int Code { get; set; }
        
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}