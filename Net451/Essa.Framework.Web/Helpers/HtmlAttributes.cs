﻿namespace Alfazema.Framework.Web.Helpers
{
    using System.Web.Routing;


    class HtmlAttributes
    {
        private RouteValueDictionary _attributes;

        public object this[string index]
        {
            get
            {
                return _attributes[index];
            }
            set
            {
                _attributes[index] = value;
            }
        }

        public void IfIsNull(string key, object valor)
        {
            _attributes[key] = _attributes[key] ?? valor;
        }

        public HtmlAttributes(object htmlAttributes)
        {
            if (htmlAttributes == null)
                _attributes = new RouteValueDictionary();
            else
                _attributes = new RouteValueDictionary(htmlAttributes);
        }

        public new string ToString()
        {
            return _attributes.ParametrosParaString();
        }
    }
}
