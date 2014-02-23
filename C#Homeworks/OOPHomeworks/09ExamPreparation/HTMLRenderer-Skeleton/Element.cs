using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLRenderer
{
    class Element:IElement
    {
        
        
        private List<IElement> childElements;

        public Element(string name)
        {
            this.Name = name;
            this.childElements = new List<IElement>();
        }
        public Element(string name, string textContent):this(name)
        {
            this.TextContent = textContent;     
        }

        public virtual string Name
        {
            get;
            private set;

        }

        public virtual string TextContent
        {
            get
            ;
            set;
        }

        public  IEnumerable<IElement> ChildElements
        {
            get { return this.childElements; }
        }

        public virtual  void AddElement(IElement element)
        {
            this.childElements.Add(element);
        }

        public virtual void Render(StringBuilder output)
        {
            if (this.Name != null)
            {
                output.AppendFormat("<{0}>", this.Name);
            }

            if (this.TextContent != null)
            {
                foreach (var ch in this.TextContent)
                {


                    if (ch == '<')
                    {
                        output.Append("&lt;");
                    }
                    else if (ch == '>')
                    {
                        output.Append("&gt;");
                    }
                    else if (ch == '&')
                    {
                        output.Append("&amp;");
                    }
                    else
                    {
                        output.Append(ch);
                    }
                }
            }

            if (this.ChildElements.Count() > 0)
            {
                foreach (var item in this.ChildElements)
                {
                    output.Append(item.ToString());
                }
            }
            if (this.Name != null)
            {
                output.AppendFormat("</{0}>", this.Name);
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            Render(output);
            return output.ToString();
        }
    }
}
