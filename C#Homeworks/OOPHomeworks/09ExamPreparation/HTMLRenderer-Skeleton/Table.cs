using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLRenderer
{
    class Table: Element,ITable
    {
        public const string name = "table";
        private int rows;
        private int cols;
        private IElement[,] cells;
        public Table(int rows,int cols) : base("table",name)
        {
            this.rows = rows;
            this.cols = cols;
            this.cells = new IElement[this.Rows,this.Cols];
        }

        public int Rows
        {
            get { return this.rows; }
        }

        public int Cols
        {
            get { return this.cols; }
        }

        public IElement this[int row, int col]
        {
            get
            {
                return this.cells[row, col];
            }
            set
            {
                if (row >= this.Rows || col >= this.Cols)
                {
                    throw new IndexOutOfRangeException();
                }
                this.cells[row, col] = value;
            }
        }

        public override string Name
        {
            get { return name;}
        }

        public override string TextContent
        {
            get { return null; }
        }
           

       
      

        

        public override void Render(StringBuilder output)
        {
            output.AppendFormat("<{0}>", this.Name);

            for (int i = 0; i < this.Rows; i++)
            {
                output.Append("<tr>");
                for (int j = 0; j < this.Cols; j++)
                {
                    output.Append("<td>");
                    output.Append(this.cells[i, j].ToString());
                    output.Append("</td>");
                }
                output.Append("</tr>");
            }

            output.AppendFormat("</{0}>", this.Name);

        }
    }
}
