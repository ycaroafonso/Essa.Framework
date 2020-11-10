namespace Essa.Framework.Web.Helpers.Metronic.Tabs
{
    using System;
    using System.Collections.Generic;
    using System.Web.Mvc;


    public class LineTabsBuilder : IDisposable
    {
        ViewContext _html;
        private string _id;
        Queue<TabConfig> _tabIds;
        int _index;
        int _indexAbaAtiva;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="html"></param>
        /// <param name="id">ID do componente</param>
        /// <param name="indexTabAtiva">Começando na posição 0</param>
        public LineTabsBuilder(ViewContext html, string id, int indexAbaAtiva)
        {
            _id = id;
            _tabIds = new Queue<TabConfig>();
            _html = html;
            _indexAbaAtiva = indexAbaAtiva;

            _html.Writer.Write(string.Concat("<ul class=\"nav nav-tabs nav-tabs-line\" id=\"", _id, "_head\">"));
        }



        public void Tab(string titulo, string onClick = "")
        {
            int index = _tabIds.Count;
            bool isAtivo = index == _indexAbaAtiva;

            _tabIds.Enqueue(new TabConfig(titulo, isAtivo, string.Concat(_id, "_tab_", index)));

            _html.Writer.Write(string.Format(@"<li class=""nav-item"">
                                   <a class=""nav-link {3}"" href=""#{1}_tab_{2}"" data-toggle=""tab"" {4}>
                                       {0}
                                   </a>
                               </li>", titulo, _id, index, isAtivo ? "active" : "", onClick == "" ? "" : "onclick=\"" + onClick + "\""));
        }



        public TabsItem Tab()
        {
            _index++;
            if (_index == 1)
                _html.Writer.Write(string.Concat("</ul><div class=\"tab-content mt-5\" id=\"", _id, "_body\">"));

            return new TabsItem(_html, _tabIds.Dequeue());
        }

        public void Dispose()
        {
            _html.Writer.Write("</div>");
        }
    }


    public class TabsItem : IDisposable
    {
        ViewContext _html;

        public TabsItem(ViewContext html, TabConfig tabConfig)
        {
            _html = html;
            html.Writer.Write($"<div class=\"tab-pane fade {(tabConfig.IsAtivo ? "show active" : "")}\" id=\"{tabConfig.IdAba}\" role=\"tabpanel\">");
        }

        public void Dispose()
        {
            _html.Writer.Write("</div>");
        }
    }

    public class TabConfig
    {
        public string Titulo { get; set; }
        public bool IsAtivo { get; set; }
        public string IdAba { get; set; }

        public TabConfig(string titulo, bool isAtivo, string idAba)
        {
            Titulo = titulo;
            IsAtivo = isAtivo;
            IdAba = idAba;
        }
    }
}
