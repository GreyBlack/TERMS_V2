using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using TERMS_V2.Domain.Interface;

namespace TERMS_V2.Repository
{
    /// <summary>
    /// IDbContext is the repository backbone.
    /// </summary>
    public interface IDbContext
    {
        IDbConnection DbConnection { get; set; }
        IDbTransaction DbTransaction { get; set; }
    }
}
