using System;

namespace _04.HTMLDispatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            ElementBuilder x = new ElementBuilder("div");
            x.AddAttribute("id","page");
            x.AddAttribute("class", "links");
            x.AddContent("<p>Hello</p>");
            Console.WriteLine(x * 2);

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine(HTMLDispatcher.CreateURL("www.abv.bg","Abv.bg","Go to abv.bg.."));
            Console.WriteLine(HTMLDispatcher.CreateInput("submit", "fname", "Submit"));
            Console.WriteLine(HTMLDispatcher.CreateImage("www.abv.bg/logo.png", "Abv.bg", "Abv Logo"));
        }
    }


}
