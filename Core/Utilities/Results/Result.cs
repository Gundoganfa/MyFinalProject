using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult 
    {
        public Result(bool success, string message) : this(success)
        {
            //Success = successResult; //overloading kullandığımız için overload methodun içinde yapılıyor bu iş. aşağıdaki kod çalışsın diye :this(successResult) eklendi.
            Message = message;
        }
        public Result(bool success) //overloading - method hem tek parametreli hem de iki parametreli çalışabilir.
        {
            Success = success;
        }

        //public bool Success => throw new NotImplementedException();
        public bool Success { get; }

        public string Message { get; }
    }
}
