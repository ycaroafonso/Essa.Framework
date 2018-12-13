namespace Essa.Framework.Util.Extensions
{
    using System;
    using System.Data.Entity.Validation;
    using System.Text;


    public static class ExceptionExtensions
    {
        private static string ToMensagemErro(this DbEntityValidationException e)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var eve in e.EntityValidationErrors)
            {
                sb.AppendLine(string.Format("- Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                    eve.Entry.Entity.GetType().FullName, eve.Entry.State));
                foreach (var ve in eve.ValidationErrors)
                {
                    sb.AppendLine(string.Format("-- Property: \"{0}\", Value: \"{1}\", Error: \"{2}\"",
                        ve.PropertyName,
                        eve.Entry.CurrentValues.GetValue<object>(ve.PropertyName),
                        ve.ErrorMessage));
                }
            }
            return sb.ToString();
        }

        public static string ToMensagemErro(this Exception e, int nivel = 0)
        {
            if (e.InnerException == null) return e.Message;
            else return e.Message + "<br/>" + e.InnerException.ToMensagemErro(nivel++).PadRight(nivel, '-');
        }

        public static string ToMensagemErro(this DbEntityValidationException e, int nivel = 0)
        {
            if (e != null)
                return e.ToMensagemErro();
            else
                if (e.InnerException == null) return e.Message;
            else return e.Message + "<br/>" + e.InnerException.ToMensagemErro(nivel++).PadRight(nivel, '-');
        }

    }
}
