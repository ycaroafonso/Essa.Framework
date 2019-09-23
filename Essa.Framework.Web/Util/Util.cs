namespace Essa.Framework.Web.Util
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



        public static SelectList SimNaoBooleano()
        {
            return Framework.Util.Geral.SimNaoBooleano().ToSelectList(x => x.Key, y => y.Value);
        }
        public static SelectList SimNaoBooleano(string valorSelecionado)
        {
            return Framework.Util.Geral.SimNaoBooleano().ToSelectList(x => x.Key, y => y.Value, null, null, valorSelecionado);
        }
    }
}
