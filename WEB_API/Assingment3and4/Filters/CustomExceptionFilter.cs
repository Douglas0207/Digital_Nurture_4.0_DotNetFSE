using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.IO;

namespace Assignment3and4.Filters
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            var exception = context.Exception;

            // Log to a file
            var logPath = "logs.txt";
            var message = $"[{DateTime.Now}] EXCEPTION: {exception.Message}\n{exception.StackTrace}\n\n";
            File.AppendAllText(logPath, message);

            // Return generic response
            context.Result = new ObjectResult("An unexpected error occurred. Please contact support.")
            {
                StatusCode = 500
            };
        }
    }
}
