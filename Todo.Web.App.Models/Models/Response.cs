using Todo.Web.App.Models.Enums;

namespace Todo.Web.App.Models.Models
{
    public class Response<T>
    {
        public T Data { get; set; }
        public ResponseMessage Message { get; set; }
    }

    public class ResponseMessage
    {
        public string Message { get; set; }
        public ResponseStatus Status { get; set; }

        public ResponseMessage CreateErrorResponse(string message)
        {
            return new ResponseMessage
            {
                Message = message,
                Status = ResponseStatus.Error
            };
        }
    }
}
