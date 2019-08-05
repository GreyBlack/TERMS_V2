using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using TERMS_V2.Domain.Entity;
using TERMS_V2.Domain.Interface;

namespace TERMS_V2.Domain.Interface
{
    public interface IRepository<T> where T : AggregateRoot
    {
        int Add(T entity);
    }
}
