using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephone
{
    class GSMCallHistoryTest
    {
        static void Main()
        {
            GSM testPhone = new GSM("L6", "Motorola");
            testPhone.AddCalls(DateTime.Now, "0879454532", 62);
            testPhone.AddCalls(DateTime.Now, "8787878789", 500);
            testPhone.AddCalls(DateTime.Now, "4545454545", 420);
            testPhone.AddCalls(DateTime.Now, "1111111111", 100);
            testPhone.DisplayCallInformation();
            double finalPrice = testPhone.CalculatePrice(0.37);
            Console.WriteLine("This is the price for all the calls");
            Console.WriteLine(finalPrice);
            testPhone.DeleteCalls(500);
            double priceAfterRemoval = testPhone.CalculatePrice(0.37);
            Console.WriteLine("This is the price without the longest call:");
            Console.WriteLine(priceAfterRemoval);
            testPhone.ClearingHistory();
            testPhone.DisplayCallInformation();

        }

    }
}
