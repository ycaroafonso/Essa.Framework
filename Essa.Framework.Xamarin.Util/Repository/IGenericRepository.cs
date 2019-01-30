namespace Essa.Framework.Xamarin.Util.Repository
{
    public interface IGenericRepository
    {
        int Incluir<T>(T item);
        void Alterar<T>(T item);
        int Excluir<T>(int id);
    }
}
