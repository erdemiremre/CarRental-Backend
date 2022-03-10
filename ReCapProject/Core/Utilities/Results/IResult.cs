using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IResult
    {
        //get sadece okunabilirlik icin(programci baska deger giremesin)
         bool Success { get;}
         string Message { get; }
    }
}
