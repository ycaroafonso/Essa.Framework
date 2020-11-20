namespace Essa.Framework.Web.Helpers.Metronic.Modal
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Mvc;
    using System.Web.Routing;


    public interface IModalAddBotao : IDisposable
    {
        IModalAddBotao AddBotaoRodape(string id, string texto, object htmlAttributes = null);
    }

    public class ModalBuilder : IModalAddBotao
    {
        private string _id;
        private ViewContext _html;
        private Queue<string> _botoes;

        public ModalBuilder(string id)
        {
            _id = id;
        }

        public ModalBuilder(string id, ViewContext html)
        {
            _botoes = new Queue<string>();
            _id = id;
            _html = html;
        }


        private void Montar(string tituloModal, string classTamanho = "")
        {
            _html.Writer.Write($@"
<div class=""modal fade"" id=""{_id}"" tabindex=""-1"" role=""dialog"" aria-labelledby=""staticBackdrop"" aria-hidden=""true"">
    <div class=""modal-dialog {classTamanho}"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">{tituloModal}</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <i aria-hidden=""true"" class=""ki ki-close""></i>
                </button>
            </div>
            <div class=""modal-body"">");
        }

        public IModalAddBotao Modal(string tituloModal)
        {
            Montar(tituloModal, " modal-dialog-centered modal-lg");
            return this;
        }

        public IModalAddBotao ModalGrande(string tituloModal)
        {
            Modal(tituloModal);
            return this;
        }


        public IModalAddBotao AddBotaoRodape(string id, string texto, object htmlAttributes = null)
        {
            RouteValueDictionary attr;

            if (htmlAttributes == null)
                attr = new RouteValueDictionary();
            else
                attr = new RouteValueDictionary(htmlAttributes);


            attr["id"] = attr["id"] ?? id;
            attr["class"] = attr["class"] ?? "btn btn-default";
            attr["type"] = attr["type"] ?? "button";

            string parametros = attr.ParametrosParaString();

            _botoes.Enqueue(string.Concat("<button ", parametros, ">", texto, "</button>"));
            return this;
        }



        private string Parte2()
        {
            string html = @"</div><div class=""modal-footer"">";

            while (_botoes.Any())
                html += _botoes.Dequeue();

            html += "</div></div></div></div>";

            return html;
        }

        public void Dispose()
        {
            _html.Writer.Write(Parte2());
        }
    }
}
