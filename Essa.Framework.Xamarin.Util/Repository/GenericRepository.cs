namespace Essa.Framework.XamarinUtil.Repository
{
    using System;
    using System.Collections.Generic;


    public class BaseGenericRepository<T> : IGenericRepository
        where T : class
    {
        public void Alterar<T1>(T1 item)
        {
            throw new NotImplementedException();
        }

        public int Excluir<T1>(int id)
        {
            throw new NotImplementedException();
        }

        public int Incluir<T1>(T1 item)
        {
            throw new NotImplementedException();
        }
    }
}
