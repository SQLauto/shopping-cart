using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using ShoppingStore.Web.Models;
using System.Text;

namespace ShoppingStore.Web.Infrastructure
{
    public static class PaingHelper
    {
        public static MvcHtmlString PageLinks(this HtmlHelper html, PageInfo pageInfo, Func<int, string> pageURL)
        {
            StringBuilder result = new StringBuilder();
            for (int p = 1; p <= pageInfo.TotalPages; p++)
            {
                //establish a page link
                TagBuilder tag = new TagBuilder("a");
                tag.MergeAttribute("href", pageURL(p));
                tag.InnerHtml = p.ToString();
                //add css class for current page number
                if (p==pageInfo.CurrentPage)
                {
                    tag.AddCssClass("selected");
                    tag.AddCssClass("pageBtn-primary");
                }
                //add css class for all page numbers
                tag.AddCssClass("pageBtn");
                result.Append(tag.ToString());    
            }
            return MvcHtmlString.Create(result.ToString());
        }
    }
}