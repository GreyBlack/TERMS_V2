using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using TERMS_V2.Domain.Interface;

namespace TERMS_V2.Domain.Interface
{
    /// <summary>
    /// IUnitOfWork is an encapsulation of IDbTransaction, and ensures that when working with multiple repositories, they share a single database context.
    /// </summary>
    public interface IUnitOfWork
    {
        void Commit();
        void Rollback();
    }
}
