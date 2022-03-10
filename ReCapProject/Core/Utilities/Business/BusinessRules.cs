using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Business
{
    //bizim için bir araç olucak.
    public class BusinessRules
    {
        public static IResult Run(params IResult[] logics)
        {
            foreach (var logic in logics)
            {
                if (!logic.Success)
                {
                    return logic; //başarısız olanı business'a bildirmek için döndürüyoruz burada.
                }
            }
            return null;
        }
    }
}
