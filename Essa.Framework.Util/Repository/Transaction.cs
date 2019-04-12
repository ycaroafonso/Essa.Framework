namespace Essa.Framework.Util.Repository
{
    using System.Data.Entity;


    public class Transaction<TContext> : ITransaction
        where TContext : DbContext
    {
        DbContextTransaction _transact;
        TContext _contexto;

        public Transaction(TContext contexto)
        {
            _contexto = contexto;
            _transact = _contexto.Database.BeginTransaction();
        }

        public void Commit()
        {
            _transact.Commit();
        }

        public void Dispose()
        {
            _transact.Dispose();
        }

        public void Rollback()
        {
            _transact.Rollback();
        }
    }
}
