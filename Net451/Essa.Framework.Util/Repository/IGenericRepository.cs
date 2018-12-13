namespace Alfazema.Framework.Util.Repository
{
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;


    public interface IGenericReadRepository<T>
        where T : class
    {
        IQueryable<T> ObterTodos();
    }

    public interface IGenericIncluirRepository<T> : IGenericSalvarRepository<T>
        where T : class
    {
        IGenericRepository<T> Incluir(T instancia);
        IGenericRepository<T> Incluir(ICollection<T> instancia);
    }

    public interface IGenericAlterarRepository<T> : IGenericSalvarRepository<T>
        where T : class
    {
        IGenericRepository<T> Alterar(T instancia);

    }

    public interface IGenericAnexarRepository<T> : IGenericSalvarRepository<T>
        where T : class
    {
        IGenericRepository<T> Anexar(ICollection<T> lista, EntityState state);

        IGenericRepository<T> Anexar(T instancia);

        IGenericRepository<T> Anexar(T instancia, EntityState state);
    }


    public interface IGenericExcluirRepository<T> : IGenericSalvarRepository<T>
        where T : class
    {
        IGenericRepository<T> Excluir(T instancia);
        IGenericRepository<T> Excluir(List<T> instancia);
    }

    public interface IGenericSalvarRepository<T>
                where T : class
    {
        void Salvar();
    }

    public interface IGenericRepository<T> : IGenericReadRepository<T>, IGenericIncluirRepository<T>, IGenericAlterarRepository<T>, IGenericAnexarRepository<T>, IGenericExcluirRepository<T>
        where T : class
    {



    }
}
