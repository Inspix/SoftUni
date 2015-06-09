using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.HTMLDispatcher
{
    class HTMLDispatcher
    {
        public static string CreateImage(string source, string alt, string title)
        {
            ElementBuilder result = new ElementBuilder("img");
            result.AddAttribute("src", source);
            result.AddAttribute("alt", alt);
            result.AddAttribute("title", title);
            return result.ToString();

        }

        public static string CreateURL(string url, string title, string text)
        {
            ElementBuilder result = new ElementBuilder("a");
            result.AddAttribute("href", url);
            result.AddAttribute("title", title);
            result.AddContent(text);
            return result.ToString();
        }

        public static string CreateInput(string type, string name, string value)
        {
            ElementBuilder result = new ElementBuilder("input");
            result.AddAttribute("type", type);
            result.AddAttribute("name", type);
            result.AddAttribute("value", value);
            return result.ToString();
        }
    }
}
