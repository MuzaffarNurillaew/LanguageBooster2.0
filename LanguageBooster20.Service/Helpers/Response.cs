namespace LanguageBooster20.Service.Helpers
{
    public class Response<T>
    {
        public int StatusCode { get; set; } = 404;
        public string Message { get; set; } = "Problem occured";
        public T Value { get; set; }
    }
}
