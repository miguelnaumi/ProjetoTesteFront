using System.Net;

namespace TesteProjetoFront.Models
{
    public class ResponseMicroService<T>
    {
        public int StatusCode { get; set; }

        public string Message { get; set; }

        public T Result { get; set; }

        public string ProcessingTime { get; set; }
    }

}
