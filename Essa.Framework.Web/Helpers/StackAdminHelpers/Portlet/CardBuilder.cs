namespace Essa.Framework.Web.Helpers.StackAdminHelpers.Portlet
{
    using System;
    using System.Web.Mvc;


    public class CardBuilder : IDisposable
    {
        private ViewContext _html;


        public CardBuilder(string id, ViewContext html, string titulo)
        {
            _html = html;

            _html.Writer.Write($@"<div class=""card"" id=""{id}"">
                            <div class=""card-header card-header-large bg-white"">
                                <h4 class=""card-header__title"">{titulo}</h4>
                            </div>
                            <div class=""card-body"">");
        }

        public CardBuilder(string id, ViewContext html)
        {
            _html = html;

            _html.Writer.Write($@"<div class=""card"" id=""{id}"">
                            <div class=""card-body"">");
        }


        public void Dispose()
        {
            _html.Writer.Write(@"</div></div>");
        }
    }
}
