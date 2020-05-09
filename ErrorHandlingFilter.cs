using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace LibTest
{
    public class ErrorHandlingFilter : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            var exception = context.Exception;
            Log(exception.Message);
            context.ExceptionHandled = true; //optional 
        }

        public void Log(string text)
        {
            Console.WriteLine(text);
        }
    }
}
