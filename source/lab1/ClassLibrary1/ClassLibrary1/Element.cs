using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleLibrary
{
    public class Element
    {
        Element? parent;
        string name;

        public Element(string name)
        {
            this.name = name;   
        }

        public Element(Element parent, string name) { this.parent = parent; this.name = name; }

        public Element getParent()
        {
            return this.parent;
        }

        public override string ToString()
        {
            return this.name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }
    }
}
