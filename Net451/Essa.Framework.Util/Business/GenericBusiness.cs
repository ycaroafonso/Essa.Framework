using Alfazema.Framework.Util.Repository;

namespace Alfazema.Framework.Util.Business
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
