﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLRenderer
{
    public class HTMLElementFactory : IElementFactory
    {
        public IElement CreateElement(string name)
        {
            return new Element(name,null);
        }

        public IElement CreateElement(string name, string content)
        {
            return new Element(name, content);
        }

        public ITable CreateTable(int rows, int cols)
        {
            return new Table(rows, cols);
        }
    }
}
