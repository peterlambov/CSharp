﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamWork
{
    public class Billing
    {
        private TariffPlan plan;
        private CDR cdr;
        private Subscriber subscriber;

        public Subscriber Subscriber
        {
            get
            {
                return this.subscriber;
            }
            set
            {
                this.subscriber = value;
            }
        }

        public CDR Cdr
        {
            get
            {
                return this.cdr;
            }
            set
            {
                this.cdr = value;
            }
        }

        public TariffPlan Plan
        {
            get
            {
                return this.plan;
            }
            set
            {
                this.plan = value;
            }
        }

        public long CalculateCallAmount(int index, int duration = 0)
        {
            return 0;
        }

        public int CalculateIndex()
        {
            return 0;
        }

        public void ReadCDR()
        {
        }

        public static void ChargeSubscriber()
        {
        }
    }
}
