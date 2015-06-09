using System.Text;

namespace _04.HTMLDispatcher
{
    internal class ElementBuilder
    {
        private string tag;
        private StringBuilder atrributes = new StringBuilder();
        private StringBuilder content = new StringBuilder();

        public ElementBuilder(string tag)
        {
            this.tag = tag;
        }

        public void AddAttribute(string attribute, string value)
        {
            this.atrributes.Append(" " + attribute + "=\"" + value + "\"");
        }

        public void AddContent(string str)
        {
            this.content.Append(str);
        }

        public override string ToString()
        {
            return string.Format("<{0}{1}>{2}",this.tag,this.atrributes,string.IsNullOrWhiteSpace(this.content.ToString()) ? "" : string.Format("{0}</{1}>",this.content,this.tag));
        }

        public static string operator *(ElementBuilder element, int mult)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < mult; i++)
            {
                sb.Append(element);
            }
            return sb.ToString();
        }
    }

}
