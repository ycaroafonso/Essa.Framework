namespace Essa.Framework.Web.Helpers.Metronic
{
    using Essa.Framework.Web.Helpers.Metronic.Tabs;
    using System.Web.Mvc;


    public static class MetronicExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="id">ID do componente</param>
        /// <returns></returns>
        public static Metronic Metronic(this HtmlHelper htmlHelper, string id)
        {
            return new Metronic(htmlHelper, id);
        }
    }

    public class Metronic
    {
        private HtmlHelper _htmlHelper;
        private string _id;

        public Metronic(HtmlHelper htmlHelper, string id)
        {
            _htmlHelper = htmlHelper;
            _id = id;
        }

        public LineTabsBuilder LineTabs(int indexAbaAtiva = 0)
        {
            return new LineTabsBuilder(_htmlHelper.ViewContext, _id, indexAbaAtiva);
        }
    }
}
