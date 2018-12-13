namespace Alfazema.Framework.Util.Repository
{
    using Alfazema.Framework.Util.Extensions;
    using System;
    using System.Data.Entity.Validation;
    using System.Text;

    [Serializable]
    public class GenericExceptionRepository : Exception
    {
        public GenericExceptionRepository()
            : base()
        { }

        public GenericExceptionRepository(string message)
            : base(message)
        { }

        public GenericExceptionRepository(string format, params object[] args)
            : base(string.Format(format, args))
        { }

        public GenericExceptionRepository(string message, Exception innerException)
            : base(message, innerException)
        { }

        public GenericExceptionRepository(string format, Exception innerException, params object[] args)
            : base(string.Format(format, args), innerException)
        { }

        public override string Message
        {
            get
            {
                var innerException = InnerException as DbEntityValidationException;
                if (innerException != null)
                {
                    StringBuilder sb = new StringBuilder();

                    sb.AppendLine();
                    sb.AppendLine();

                    sb.Append(innerException.ToMensagemErro());

                    sb.AppendLine();

                    return sb.ToString();
                }

                return base.Message;
            }
        }
    }
     
}
