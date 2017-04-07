using OnlineshoppingStore.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace OnlineshoppingStore.WebUI.HtmlHelpers
{
    public static class PagingHelpers
    {
        public static MvcHtmlString PageLinks(this HtmlHelper html,
                                                PagingInfo pagingInfo,
                                                Func<int, string> pageURL)
        {
            StringBuilder results = new StringBuilder();
            for (int i = 1; i <= pagingInfo.TotalPages; i++)
            {
                TagBuilder tag = new TagBuilder("a");
                tag.MergeAttribute("href", pageURL(i));
                tag.InnerHtml = i.ToString();
                if (i == pagingInfo.CurrentPage) { 
                    tag.AddCssClass("selected");
                    tag.AddCssClass("btn btn-primary btn-md");
                }
                tag.AddCssClass("btn btn-default btn-md");
                results.Append(tag.ToString());
            }
            return MvcHtmlString.Create(results.ToString());
        }
    }
}