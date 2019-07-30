using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using TERMS_V2.Domain.Interface;

namespace TERMS_V2.Repository
{
    public class DbContext : IDbContext
    {
        // TODO 初始化 conn
        public IDbConnection DbConnection { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IDbTransaction DbTransaction { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
