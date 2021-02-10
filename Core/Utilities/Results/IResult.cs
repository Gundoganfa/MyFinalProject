using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    // temel voidler için başlangıç
    public interface IResult
    {
        bool Success { get; } // constructor'da set edilebilir
        string Message { get; }
    }
}
