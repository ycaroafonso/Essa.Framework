namespace Essa.Framework.Web.Helpers.Bootstrap
{
    using DropDown;
    using Portlet;
    using Essa.Framework.Web.Helpers.Bootstrap.Accordion;
    using Essa.Framework.Web.Helpers.Bootstrap.Modal;
    using Essa.Framework.Web.Helpers.Bootstrap.Tabs;
    using System;
    using System.Collections.Generic;
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

        public TabsBuilder Tabs(int indexAbaAtiva = 0)
        {
            return new TabsBuilder(_htmlHelper.ViewContext, _id, indexAbaAtiva);
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

        public PortletBuilder Portlet(string titulo, string classPortlet = "portlet box blue", string classIconeTitulo = "fa fa-gift")
        {
            return new PortletBuilder(_id, _htmlHelper.ViewContext, titulo, classPortlet, classIconeTitulo);
        }

        public MvcHtmlString DropDown(string titulo, List<DropDownItem> itens)
        {
            return new DropDownBuilder(_id, _htmlHelper.ViewContext).AddItem(itens).Texto(titulo).Montar();
        }
        public MvcHtmlString DropDown(List<DropDownItem> itens)
        {
            return new DropDownBuilder(_id, _htmlHelper.ViewContext).AddItem(itens).Montar();
        }
    }
}
