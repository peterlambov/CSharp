using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamWork
{
    public class GPRS : IChargeable
    {
        public struct GPRSTariffIndexTable
        {
            public struct Quota
            {
                public int Size { get; set; } //In seconds
                public double Price { get; set; } //In stotinki
            }

            public int Index { get; private set; }
            public Quota TrafficQuota;//{ get; set; }

            //Constructor
            public GPRSTariffIndexTable(string data)
                : this()
            {
                //TODO: Comma separated data loaded from file
                //  
                //Line format: ->Index;Quota size;Quota Price;
                //Parse the data in the structure fields
                //Деян: Имам имплементацията на метода.
                string[] array = data.Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
                this.Index = int.Parse(array[0]);
                this.TrafficQuota.Size = int.Parse(array[1]);
                this.TrafficQuota.Price = double.Parse(array[2]);
            }
        }

        public List<GPRSTariffIndexTable> ratingData = new List<GPRSTariffIndexTable>();

        public GPRS(string fileName)
        {
            //TODO: Initialize ratingData structure
            //Read from a file line by line and store them in the list
            //
            //while (endFile != null)
            //{
            //  ratingData.Add = fileName.ReadLine;
            //}
            //Деян: Имам имплементацията на метода.
        }

        public double Rate(int index)
        {
            throw new NotImplementedException();
            //To add formula
        }
    }
}
