namespace Essa.Framework.Web.Helpers.Bootstrap5
{
    using Essa.Framework.Web.Helpers.Bootstrap5.Modal;
    using System.Web.Mvc;


    public static class BootstrapExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="id">ID do componente</param>
        /// <returns></returns>
        public static Bootstrap Bootstrap(this HtmlHelper htmlHelper, string id)
        {
            return new Bootstrap(htmlHelper, id);
        }
    }

    public class Bootstrap
    {
        private HtmlHelper _htmlHelper;
        private string _id;

        public Bootstrap(HtmlHelper htmlHelper, string id)
        {
            _htmlHelper = htmlHelper;
            _id = id;
        }



        public IModalAddBotao ModalGrande(string tituloModal)
        {
            return new ModalBuilder(_id, _htmlHelper.ViewContext).ModalGrande(tituloModal);
        }

        public IModalAddBotao Modal(string tituloModal)
        {
            return new ModalBuilder(_id, _htmlHelper.ViewContext).Modal(tituloModal);
        }


    }
}
