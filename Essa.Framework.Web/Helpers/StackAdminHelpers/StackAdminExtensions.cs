namespace Essa.Framework.Web.Helpers.StackAdminHelpers
{
    using Essa.Framework.Web.Helpers.Bootstrap.Accordion;
    using Essa.Framework.Web.Helpers.Bootstrap.Modal;
    using Essa.Framework.Web.Helpers.Bootstrap.Tabs;
    using Portlet;
    using System;
    using System.Web.Mvc;


    public static class StackAdminExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="id">ID do componente</param>
        /// <returns></returns>
        public static StackAdmin StackAdmin(this HtmlHelper htmlHelper, string id)
        {
            return new StackAdmin(htmlHelper, id);
        }
    }

    public class StackAdmin
    {
        private HtmlHelper _htmlHelper;
        private string _id;

        public StackAdmin(HtmlHelper htmlHelper, string id)
        {
            _htmlHelper = htmlHelper;
            _id = id;
        }

        public TabsBuilder Tabs(int indexAbaAtiva = 0)
        {
            return new TabsBuilder(_htmlHelper.ViewContext, _id, indexAbaAtiva);
        }

        public MvcHtmlString BotaoComModalAjax(string tituloBotao, string url, Action<IModalAddBotao> config = null)
        {
            return new ModalBuilder(_id).BotaoComModalAjax(tituloBotao, url, config);
        }

        public IModalAddBotao BotaoComModalSimples(string tituloBotao, string tituloModal, object htmlAttributesBotao = null)
        {
            return new ModalBuilder(_id, _htmlHelper.ViewContext).BotaoComModalSimples(tituloBotao, tituloModal, htmlAttributesBotao);
        }

        public IModalAddBotao ModalGrande(string tituloModal)
        {
            return new ModalBuilder(_id, _htmlHelper.ViewContext).ModalGrande(tituloModal);
        }

        public IModalAddBotao Modal(string tituloModal)
        {
            return new ModalBuilder(_id, _htmlHelper.ViewContext).Modal(tituloModal);
        }

        public AccordionBuilder Accordion()
        {
            return new AccordionBuilder(_htmlHelper.ViewContext, _id);
        }

        public CardBuilder Card(string titulo)
        {
            return new CardBuilder(_id, _htmlHelper.ViewContext, titulo);
        }
        public CardBuilder Card()
        {
            return new CardBuilder(_id, _htmlHelper.ViewContext);
        }

        //public MvcHtmlString DropDown(string titulo, List<DropDownItem> itens)
        //{
        //    return new DropDownBuilder(_id, _htmlHelper.ViewContext).AddItem(itens).Texto(titulo).Montar();
        //}
        //public MvcHtmlString DropDown(List<DropDownItem> itens)
        //{
        //    return new DropDownBuilder(_id, _htmlHelper.ViewContext).AddItem(itens).Montar();
        //}
    }
}
