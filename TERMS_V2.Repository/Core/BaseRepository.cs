using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using TERMS_V2.Domain.Entity;
using Dapper;
using TERMS_V2.Domain.Interface;
using System.Linq;

namespace TERMS_V2.Repository
{
    public abstract class BaseRepository<T> : IRepository<T> where T : AggregateRoot
    {
        private readonly IDbContext _context;

        public BaseRepository(IDbContext context)
        {
            if (_context != null) _context = context;
        }

        public IDbConnection GetDbConn()
        {
            return _context.DbConnection;
        }

        public int Add(T entity)
        {
            return GetDbConn().Execute("", entity);
        }

        public List<T> Query(string sql, object param = null)
        {
            return GetDbConn().Query<T>(sql, param).ToList();
        }
    }
}
