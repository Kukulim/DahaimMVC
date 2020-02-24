using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace DahaimMVC
{
    public static class HtmlExtImage
    {
        public static MvcHtmlString Image(this HtmlHelper htmlHrlper, 
                                          string src,
                                          string altText,
                                          string cssClass,
                                          string name = null,
                                          object htmlAtributes = null)
        {

            TagBuilder tb = new TagBuilder("img");

            if (!string.IsNullOrWhiteSpace(name))
            {
                HtmlExtCommon.AddNameAndId(tb, name, "");
            }

            tb.MergeAttribute("src", src);
            tb.MergeAttribute("alt", altText);

            tb.MergeAttributes(HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAtributes)); 

            if (!string.IsNullOrWhiteSpace(cssClass))
            {
                tb.AddCssClass(cssClass);
            }

            return MvcHtmlString.Create(tb.ToString(TagRenderMode.SelfClosing));
        }
    }
}