namespace Alfazema.Framework.Web.Util
{
    using Extensions;
    using System.Web.Mvc;


    public static class Util
    {

        public static SelectList SimNao()
        {
            return Framework.Util.Geral.SimNao().ToSelectList(x => x.Key, y => y.Value);
        }
        public static SelectList SimNao(string valorSelecionado)
        {
            return Framework.Util.Geral.SimNao().ToSelectList(x => x.Key, y => y.Value, null, null, valorSelecionado);
        }
    }
}
