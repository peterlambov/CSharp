using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


   public class Display
    {
       //fields
        private decimal? size;
        private decimal? numberOfColors;
       //constructor
        public Display(decimal sizE, decimal numOfColors)
        {
            this.Size = sizE;
            this.NumberOfColors = numOfColors;
        }
       //task 5
        public decimal? Size
        {
            get { return this.size; }
            set
            {
                if (value >= 0 || value == null)
                {
                    this.size = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
       
        public decimal? NumberOfColors
        {
            get { return this.numberOfColors; }
            set
            {
                if (value >= 0 || value == null)
                {
                    this.numberOfColors = value;

                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
    }

