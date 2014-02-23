using System;
using System.Linq;

public class Worker:Human
{
      private int weekSalary;
      private int workHoursPerDay;

      public Worker(int weeksalary, int workhoursperday, string firstname, string lastname)
          : base(firstname, lastname)
      {
          this.WeekSalary = weeksalary;
          this.WorkHoursPerDay = workhoursperday;
      }

    public int WeekSalary
    {
        get { return this.weekSalary; }

        set
        {
            if (value <= 0)
            {
                throw new ArgumentException();
            } 
            this.weekSalary = value;
        }
    }

    public int WorkHoursPerDay
    {
        get {return this.workHoursPerDay; }

        set
        {
            if (value <= 0)
            {
                throw new ArgumentException();
            } 
            this.workHoursPerDay = value;
        }
    }

    public double MoneyPerHour()
    {
        double result = 0;
        result = (this.weekSalary / 5) / this.workHoursPerDay;
        return result;
    }
}

