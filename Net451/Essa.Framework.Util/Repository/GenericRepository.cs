namespace Alfazema.Framework.Util.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Linq;
    using System.Runtime.Remoting.Messaging;


    public interface IGenericBaseRepository : IDisposable
    {
        DbRawSqlQuery<T> SqlQuery<T>(string sql, params object[] parametros);
        int ExecuteSqlCommand(string sql, params object[] parametros);
        DbContextTransaction BeginTransaction();
    }


    public class GenericRepository<TContext> : IGenericBaseRepository
        where TContext : DbContext
    {

        string _nomeInstancia;


        protected TContext Contexto { get; private set; }

        private void NovoContexto()
        {
            Contexto = (TContext)Activator.CreateInstance(typeof(TContext));
        }
        private void SetContexto(TContext contexto)
        {
            CallContext.SetData(_nomeInstancia, contexto);
        }
        protected TContext GetContexto()
        {
            return (TContext)CallContext.GetData(_nomeInstancia);
        }


        public GenericRepository()
        {
            _nomeInstancia = typeof(TContext).ToString();

            Contexto = GetContexto();

            if (Contexto == null)
            {
                NovoContexto();
                SetContexto(Contexto);
            }
        }

        public GenericRepository(TContext contexto)
        {
            _nomeInstancia = typeof(TContext).ToString();
            Contexto = contexto;
        }





        public DbRawSqlQuery<T> SqlQuery<T>(string sql, params object[] parametros)
        {
            return Contexto.Database.SqlQuery<T>(sql, parametros);
        }

        public int ExecuteSqlCommand(string sql, params object[] parametros)
        {
            return Contexto.Database.ExecuteSqlCommand(sql, parametros);
        }

        public DbContextTransaction BeginTransaction()
        {
            return Contexto.Database.BeginTransaction();
        }







        public IQueryable<T> ObterTodos<T>() where T : class
        {
            return Contexto.Set<T>();
        }


        public void Anexar<T>(T instancia) where T : class
        {
            Contexto.Set<T>().Attach(instancia);
        }
        public void Anexar<T>(T instancia, EntityState state) where T : class
        {
            Contexto.Set<T>().Attach(instancia);
            Contexto.Entry(instancia).State = state;
        }


        public void Alterar<T>(T instancia) where T : class
        {
            Anexar(instancia, EntityState.Modified);
        }





        public void Dispose()
        {
            Contexto.Dispose();
            CallContext.FreeNamedDataSlot(_nomeInstancia);
        }
    }


    public class GenericRepository<T, TContext> : GenericRepository<TContext>, IGenericRepository<T>
        where T : class
        where TContext : DbContext
    {
        public GenericRepository() : base() { }

        public GenericRepository(TContext contexto) : base(contexto) { }



        public IQueryable<T> ObterTodos()
        {
            return Contexto.Set<T>();
        }



        public IGenericRepository<T> Incluir(T instancia)
        {
            Contexto.Set<T>().Add(instancia);

            return this;
        }
        public IGenericRepository<T> Incluir(ICollection<T> instancia)
        {
            Contexto.Set<T>().AddRange(instancia);

            return this;
        }



        public IGenericRepository<T> Alterar(T instancia)
        {
            return Anexar(instancia, EntityState.Modified);
        }


        public IGenericRepository<T> Excluir(T instancia)
        {
            Contexto.Set<T>().Attach(instancia);
            Contexto.Entry(instancia).State = EntityState.Deleted;

            return this;
        }
        public IGenericRepository<T> Excluir(List<T> instancia)
        {
            foreach (var item in instancia)
            {
                Contexto.Set<T>().Attach(item);
                Contexto.Entry(item).State = EntityState.Deleted;
            }

            return this;
        }


        [Obsolete]
        public IGenericRepository<T> Anexar(T instancia)
        {
            Contexto.Set<T>().Attach(instancia);

            return this;
        }
        [Obsolete]
        public IGenericRepository<T> Anexar(T instancia, EntityState state)
        {
            Contexto.Set<T>().Attach(instancia);
            Contexto.Entry(instancia).State = state;

            return this;
        }

        public IGenericRepository<T> Anexar(ICollection<T> lista, EntityState state)
        {
            foreach (var item in lista)
                Anexar(item, state);

            return this;
        }



        public void Salvar()
        {
            Contexto.SaveChanges();
        }
    }

}
