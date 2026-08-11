using System.Net;

public class ExternalApiException : Exception
{
    public HttpStatusCode StatusCode { get; }
    public string Url { get; }
    public string Method { get; }
    public string ResponseBody { get; }

    public ExternalApiException(string message,HttpStatusCode statusCode, string url, string method, string responseBody, Exception? inner = null): base(message, inner)
    {
        StatusCode = statusCode;
        Url = url;
        Method = method;
        ResponseBody = responseBody;
    }
}
