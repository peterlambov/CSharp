using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamWork
{
    public class Destination : RatingItems
    {

        //Constructors
        public Destination()
            : base()
        {

        }


        public Destination(string ratingDataFileName)
            : base(ratingDataFileName)
        {

        }

        //Methods
        public override T Index<T>(params object[] searchKey)
        {
            if (searchKey.Length != 1)
                throw new ArgumentException("Class Destination can recieve only 1 argument");


            string searchKeyString = searchKey[0] as string;

                if (searchKeyString == null)
                throw new ArgumentException("Class Destination can recieve only string arguments");

            int count = (searchKey[0] as string).Length;
            int index = -1;

            //Best match algorithm. Match the MSISDN to destination Area
            while (searchKeyString.Length > 0)
            {
                index = this.ratingTable.FindIndex(x => x.SearchKey == searchKeyString);

                if (index != -1)
                {
                    var result = this.ratingTable[index].Index;
                    
                    if (result is T)
                    {
                        return (T)(object)result;
                    }
                    else
                    {
                        try
                        {
                            return (T)Convert.ChangeType(result, typeof(T));
                        }
                        catch (InvalidCastException ice)
                        {
                            throw new InvalidCastException("The method Return type doesn't match the Invoke (generic) type", ice);
                            //return default(T);
                        }
                    }
                }

                searchKeyString = searchKeyString.Remove(searchKeyString.Length - 1); //Remove last char and continue with best mach search
            }

            return default(T);
        }
    }
}
