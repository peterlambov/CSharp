using System;
using System.Linq;

    class Call
    {
        //fields
        private DateTime dateTime;
        private string dialedPhoneNumber;
        private decimal duration;      //in seconds
        //constructors
        public Call(DateTime dateAndTime, string dialedNumber, decimal duration)
        {
            this.dateTime = dateAndTime;
            this.dialedPhoneNumber = dialedNumber;
            this.duration = duration;
        }

        //properties
        public DateTime DateAndTime
        {
            get { return this.dateTime; }
            set { this.dateTime = value; }
        }

        public string DialedPhoneNumber
        {
            get { return this.dialedPhoneNumber; }
            set { this.dialedPhoneNumber = value; }
        }

        public decimal Duration
        {
            get { return this.duration; }
            set { this.duration = value; }
        }
    }

