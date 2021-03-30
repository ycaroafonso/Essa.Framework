namespace Essa.Framework.Web.Helpers.Bootstrap5.Modal
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
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

        public IModalAddBotao Modal(string tituloModal)
        {
            _html.Writer.Write(Parte1(tituloModal));

            return this;
        }

        public IModalAddBotao ModalGrande(string tituloModal)
        {
            _html.Writer.Write(string.Format(@"
<div class=""modal fade"" id=""{0}"" tabindex=""-1"" role=""basic"">
	<div class=""modal-dialog modal-lg"">
		<div class=""modal-content"">
			<div class=""modal-header"">
				<h4 class=""modal-title"">{1}</h4>
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
			</div>
			<div class=""modal-body"">", _id, tituloModal));

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
            attr["class"] = attr["class"] ?? "btn";
            attr["type"] = attr["type"] ?? "button";

            string parametros = attr.ParametrosParaString();

            _botoes.Enqueue(string.Concat("<button ", parametros, ">", texto, "</button>"));
            return this;
        }


        private string Parte1(string tituloModal)
        {
            return string.Format(@"
<div class=""modal"" id=""{0}"" tabindex=""-1"" role=""dialog"">
	<div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
			<div class=""modal-header"">
				<h5 class=""modal-title"">{1}</h5>
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
			</div>
			<div class=""modal-body"">", _id, tituloModal);
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
