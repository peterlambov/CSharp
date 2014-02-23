﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamWork
{
    public class SMS : IChargeable
    {
        public struct SMSTariffIndexTable
        {
            public struct Block
            {
                public int Symbols { get; set; } //In seconds
                public double Price { get; set; } //In stotinki
            }

            public int Index { get; private set; }
            public Block FirstBlock ;//{ get; set; }
            public Block SubseqBlock; //{ get; set; }

            //Constructor
            public SMSTariffIndexTable(string data)
                : this()
            {
                //TODO: Comma separated data loaded from file
                //
                //Line format: ->Index;First interval duration;First interval price;Subseq interval duration; Subsec interval price;
                //Parse the data in the structure fields
                //Деян: Имам имплементацията на метода.
                string[] array=data.Split(new string[] {";"},StringSplitOptions.RemoveEmptyEntries);
                this.Index = int.Parse(array[0]);
                this.FirstBlock.Symbols = int.Parse(array[1]);
                this.FirstBlock.Price = double.Parse(array[2]);
                this.SubseqBlock.Symbols = int.Parse(array[3]);
                this.SubseqBlock.Price = double.Parse(array[4]);

            }
        }


        public List<SMSTariffIndexTable> ratingData = new List<SMSTariffIndexTable>();

        public SMS(string fileName)
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

        public double Rate(int tariffIndex)
        {
            double charge = 0d;

            //TODO: search for the tariff index in the rating data
            //If match found, read the First And Subsequent Interval data

            //Calculate the charges. The Formula will be provided.
            //Return the charge
            //If no Index found, apply Default data.
            //Default tariff index is 0. It must be administered within the file holding the rating data,
            //among with the other indexes

            return charge;
        }
    
    }
}
