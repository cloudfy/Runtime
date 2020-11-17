using System;
using System.Collections.Generic;
using System.Text;

namespace Runtime.Data.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T> where T : IEntity
    {
        T Create(T obj);
        T Update(T obj);
        void Delete(T obj);
    }
}
