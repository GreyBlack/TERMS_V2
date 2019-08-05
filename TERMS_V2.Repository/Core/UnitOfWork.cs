using System;
using System.Collections.Generic;
using System.Data;
using TERMS_V2.Domain.Interface;

namespace TERMS_V2.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbContext _context;

        public UnitOfWork(IDbContext context)
        {
            _context = context;
            _context.DbTransaction = context.DbConnection.BeginTransaction();
        }

        public void Commit()
        {
            try
            {
                _context.DbTransaction.Commit();
                _context.DbTransaction.Connection?.Close();
            }
            catch
            {
                _context.DbTransaction.Rollback();
                throw;
            }
            finally
            {
                _context.DbTransaction?.Dispose();
                _context.DbTransaction.Connection?.Dispose();
                _context.DbTransaction = null;
            }
        }

        public void Rollback()
        {
            try
            {
                _context.DbTransaction.Rollback();
                _context.DbTransaction.Connection?.Close();
            }
            catch
            {
                throw;
            }
            finally
            {
                _context.DbTransaction?.Dispose();
                _context.DbTransaction.Connection?.Dispose();
                _context.DbTransaction = null;
            }
        }
    }
}
