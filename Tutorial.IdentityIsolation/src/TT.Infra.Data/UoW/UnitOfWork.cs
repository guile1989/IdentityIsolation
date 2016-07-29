using System;
using TT.Infra.Data.Context;
using TT.Infra.Data.Interface;

namespace TT.Infra.Data.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TutorialContext _context;
        private bool _disposed;

        public UnitOfWork(TutorialContext context)
        {
            _context = context;
        }

        public void BeginTransaction()
        {
            _disposed = false;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
