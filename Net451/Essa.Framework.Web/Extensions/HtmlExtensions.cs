namespace Alfazema.Framework.Web.Extensions
{
    using System;
    using System.Linq.Expressions;
    using System.Web.Mvc;
    using System.Web.Mvc.Html;
    using System.Web.Routing;


    public static class HtmlExtensions
    {
        public static MvcHtmlString TextBoxFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression, Action<RouteValueDictionary> customHtmlAttributes)
        {
            RouteValueDictionary htmlAttributes = new RouteValueDictionary();
            customHtmlAttributes(htmlAttributes);
            return htmlHelper.TextBoxFor(expression, htmlAttributes);
        }
    }
}
