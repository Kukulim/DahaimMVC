using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DahaimMVC
{
    public static class HtmlExtCommon
    {
        public static void AddNameAndId(TagBuilder tg, string name, string id)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                name = TagBuilder.CreateSanitizedId(name);
                if (string.IsNullOrWhiteSpace(id))
                {
                    tg.GenerateId(name);
                }
                else
                {
                    tg.MergeAttribute("id", TagBuilder.CreateSanitizedId(id));
                }
            }
            tg.MergeAttribute("name", name);
        }
    }
}