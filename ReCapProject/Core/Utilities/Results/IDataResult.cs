using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //IResult'tan ek olarak Data icericek.//T her şey olabilir oldugundan kisit vermiyoruz.
    public interface IDataResult<T>:IResult
    {
        T Data { get; }
    }
}
