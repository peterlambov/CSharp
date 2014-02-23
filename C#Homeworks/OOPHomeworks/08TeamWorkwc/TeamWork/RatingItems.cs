using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamWork
{
    public abstract class RatingItems : IRateable
    {
        //public DestinationZone destinationZone;
        //public Location location;
        //public DateTime startTime;

        public List<RatingData> ratingTable;

        public struct RatingData
        {
            private string searchKey;
            private int index;
            //The Rating Data is 2 dimensional table, consisted of 2 columns:
            //SearchKey | index
            //with the Index method we 
            // A) pass the input SearchKey from the CDR, 
            // B) evaluate the best match in the table
            // C) Retrieve the Index form the match row.
            //SearchKey must by column with unique values.


            //Properties
            public string SearchKey
            {
                get { return searchKey; }

                set
                {
                    if (String.IsNullOrWhiteSpace(value))
                        throw new ArgumentException("Invalid value for SearchKey provided.");

                    searchKey = value;
                }
            }

            public int Index
            {
                get { return index; }

                set
                {
                    if (value < 0 || value > int.MaxValue)
                        throw new ArgumentOutOfRangeException(String.Format("Invalid value for Index provided. Value must be positive and not greater than {0}", int.MaxValue));

                    index = value;
                }
            }

            //Struct Constructor
            public RatingData(string key, int index)
                : this()
            {
                this.SearchKey = key;
                this.Index = index;
            }
        }

        public abstract T Index<T>(params object[] searchKey);
        //Search through the Rating Data structure

        //Constructor. Needs to be protected for abstract classes
        protected RatingItems()
        {
            ratingTable = new List<RatingData>();
        }

        protected RatingItems(string ratingDataFileName)
            : this()
        {
            var data = RWFiles.LoadFile(ratingDataFileName);

            foreach (var item in data)
            {
                if (item[0][0] == '#') //If the line is comments, skip it
                    continue;
                ratingTable.Add(new RatingData(item[0], int.Parse(item[1])));
            }

            //Validate data. Check if SearchKey column is consisted only of unique values
            //Console.WriteLine((ratingTable.Select(x => x.SearchKey).Distinct().Count()));
            //Console.WriteLine(ratingTable.Select(x => x.SearchKey).Count());
            
            if ((ratingTable.Distinct().Select(x => x.SearchKey).Count()) != (ratingTable.Select(x => x.SearchKey).Count()))
                Console.WriteLine("Duplicate value(s) for SearchKey met. Rating data import failed");
                //throw new FormatException("Duplicate value(s) for SearchKey met. Rating data import failed");
        }
    }



}
