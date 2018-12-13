namespace Essa.Framework.Util.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Runtime.Remoting.Messaging;


    public class GenericRepository<TContext> : IGenericBaseRepository, IGenericRepository
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







        public virtual void Alterar<T>(T instancia) where T : class
        {
            Anexar(instancia, EntityState.Modified);
        }

        public void Anexar<T>(T instancia) where T : class
        {
            Contexto.Set<T>().Attach(instancia);
        }

        public void Anexar<T>(T instancia, EntityState state) where T : class
        {
            Anexar(instancia);
            Contexto.Entry(instancia).State = state;
        }

        public void Anexar<T>(ICollection<T> lista, EntityState state) where T : class
        {
            foreach (var item in lista)
                Anexar(item, state);

        }

        public void Excluir<T>(List<T> instancia) where T : class
        {
            foreach (var item in instancia)
            {
                Anexar(item, EntityState.Deleted);
            }
        }

        public void Excluir<T>(T instancia) where T : class
        {
            Anexar(instancia, EntityState.Deleted);
        }
        public virtual IEnumerable<T> Excluir<T>(Expression<Func<T, bool>> func) where T : class
        {
            return Contexto.Set<T>().RemoveRange(ObterTodos<T>().Where(func));
        }




        public void Incluir<T>(ICollection<T> instancia) where T : class
        {
            Contexto.Set<T>().AddRange(instancia);
        }
        public void Incluir<T>(List<T> instancia) where T : class
        {
            Contexto.Set<T>().AddRange(instancia);
        }

        public void Incluir<T>(T instancia) where T : class
        {
            Contexto.Set<T>().Add(instancia);
        }

        public int Salvar()
        {
            return Contexto.SaveChanges();
        }




        public void Dispose()
        {
            Contexto.Dispose();
            CallContext.FreeNamedDataSlot(_nomeInstancia);
        }

        public IQueryable<T> ObterTodos<T>() where T : class
        {
            return Contexto.Set<T>();
        }
    }


    public class GenericRepository<T, TContext> : GenericRepository<TContext>, IGenericRepository<T>
        where T : class
        where TContext : DbContext
    {
        public GenericRepository() : base() { }

        public GenericRepository(TContext contexto) : base(contexto) { }



        public virtual IQueryable<T> ObterTodos()
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



        public virtual IGenericRepository<T> Alterar(T instancia)
        {
            Anexar(instancia, EntityState.Modified);

            return this;
        }



        public virtual IGenericRepository<T> Excluir(T instancia)
        {
            Anexar(instancia, EntityState.Deleted);
            return this;
        }
        public virtual IGenericRepository<T> Excluir(List<T> instancia)
        {
            foreach (var item in instancia)
            {
                Anexar(instancia, EntityState.Deleted);
            }

            return this;
        }
        public virtual IEnumerable<T> Excluir(Expression<Func<T, bool>> func)
        {
            return Contexto.Set<T>().RemoveRange(ObterTodos().Where(func));
        }




        public virtual IGenericRepository<T> Anexar(T instancia)
        {
            Contexto.Set<T>().Attach(instancia);

            return this;
        }

        public virtual IGenericRepository<T> Anexar(ICollection<T> lista, EntityState state)
        {
            foreach (var item in lista)
                Anexar(item, state);

            return this;
        }

    }



}
