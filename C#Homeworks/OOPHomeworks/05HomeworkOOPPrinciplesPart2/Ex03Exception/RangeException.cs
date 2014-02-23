using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class InvalidRangeException<T> : ApplicationException
  
{
    public InvalidRangeException(string message, T start, T end,Exception innerExcept)
        : base(message,innerExcept)
    {
        this.Start = start;
        this.End = end;
    }

    public InvalidRangeException(string message, T start, T end)
        : base(message)
    {
        this.Start = start;
        this.End = end;
    }

    private T start;
    private T end;

    public T End
    {
        get
        {
            return this.end;
        }
        private set
        {
            this.end = value;
        }
    }

    public T Start
    {
        get
        {
            return this.start;
        }
        private set
        {
            this.start = value;
        }
    }
}

