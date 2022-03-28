using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Caching
{
    //Biz bunu InmemoryCache için kullancağız.Redis kullanmak istersek bunu imp. edeceğiz
    public interface ICacheManager
    {
        T Get<T>(string key); //key vereceğiz bellekten ona uyanı getireceğiz..
        object Get(string key);
        void Add(string key, object value, int duration);
        bool IsAdd(string key); //cache'de var mi?
        void Remove(string key);
        void RemoveByPattern(string pattern); 
    }
}
