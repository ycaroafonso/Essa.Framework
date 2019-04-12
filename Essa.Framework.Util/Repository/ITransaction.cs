namespace Essa.Framework.Util.Repository
{
    using System;


    public interface ITransaction : IDisposable
    {
        void Commit();
        void Rollback();
    }
}
