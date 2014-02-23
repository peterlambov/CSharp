using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


  public  class GSM
    {
      //fields
        private string model;
        private string manufacturer;
        private decimal? price;
        private string owner;
        private Battery battery;
        private Display display;
        
        //6 
        static private GSM iphoneFive=new GSM("iphoneFive","apple");
      //constructors
        public GSM(string model, string manufacturer, decimal? price, string owner, Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
        }

        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
        }
      // task 5 properties
        private List<Call> CallHistory = new List<Call>();

        public static GSM Iphone
        {
            get { return iphoneFive; }
           
        }

        public string Model
        {
            get { return this.model; }
            set
            {
                if (value.Length>=0)
                {
                    this.model = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (value.Length >= 0)
                {
                    this.manufacturer = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        public decimal? Price
        {
            get { return this.price; }
            set {
                    if (value >= 0 || value == null)
                    {
                    this.price = value;
                    }
                    else
                    {
                    throw new ArgumentException();
                    }
                }
        }

        public string Owner
        {
            get { return this.owner; }
            set
            {
                if (value.Length>0 ||value==null)
                {
                    this.owner = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
      
        public Battery Battery
        {
            get { return this.battery; }
            set { this.battery = value; }
        }

        public Display Display
        {
            get { return this.display; }
            set { this.display = value; }
        }

        private static GSM IPhone
        {
            get { return iphoneFive; }
        }

       
        // methods
        public void AddCalls(DateTime dateAndTime,string dialedNumber,decimal duration)
        {
            Call call = new Call(dateAndTime, dialedNumber, duration);
            CallHistory.Add(call);
        }

        public void DeleteCalls( decimal duration)
        {
            for (int i = 0; i < CallHistory.Count; i++)
            {
                if (CallHistory[i].Duration == duration)
                {
                    CallHistory.RemoveAt(i);
                    i--;
                }
            }
        }

        public void ClearingHistory()
        {
            CallHistory.Clear();
        }

        public double CalculatePrice(double pricePerMinute)
        {
            double sumTime = 0;
            for (int i = 0; i < CallHistory.Count; i++)
            {
                sumTime =sumTime+ (double)CallHistory[i].Duration;
            }
            return Math.Ceiling(sumTime / 60) * pricePerMinute;
        }

        public void DisplayCallInformation()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("This is the call history of the phone:");
            foreach (var call in CallHistory)
            {
                result.AppendFormat("Date: {0}, Number: {1}, Duration: {2} \n", call.DateAndTime, call.DialedPhoneNumber, call.Duration);
            }
            Console.WriteLine(result.ToString());
        }

        public override string ToString()
        {
            StringBuilder informationForPhone = new StringBuilder();
            informationForPhone.AppendLine("This is the info about the phone:");
            informationForPhone.AppendLine(this.model);
            informationForPhone.AppendLine(this.manufacturer);
            informationForPhone.AppendLine(this.price.ToString());
            informationForPhone.AppendLine(this.owner);
            informationForPhone.AppendLine(this.battery.ToString());
            informationForPhone.AppendLine(this.display.ToString());
            string info = informationForPhone.ToString();
            return info;
        }

       

    }

