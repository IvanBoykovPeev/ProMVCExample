using System;
using System.Web.Mvc;


namespace HelperMethods.Infrastructure
{
    public static class CustumHelpers
    {
        public static MvcHtmlString ListArrayItems(this HtmlHelper html, string[] list)
        {
            TagBuilder tag = new TagBuilder("ul");

            foreach (string str in list)
            {
                TagBuilder itemTag = new TagBuilder("li");
                itemTag.SetInnerText(str);
                tag.InnerHtml += itemTag.ToString();
            }

            return new MvcHtmlString(tag.ToString());
        }

        public static string DisplayMessage(this HtmlHelper html, string msg)
        {
            return String.Format("This is the message: <p>{0}<p>", msg);
        }
    }
}