using Essa.Framework.UtilCore.Repository;

namespace Essa.Framework.UtilCore.Business
{
    public interface IGenericBusiness
    {

    }

    public abstract class GenericBusiness<TRepository, T> : IGenericBusiness
        where TRepository : IGenericRepository<T>
        where T : class
    {
        protected virtual TRepository Repository { get; private set; }

        public GenericBusiness(TRepository repository)
        {
            Repository = repository;
        }
    }
}
