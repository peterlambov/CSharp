using System;
using System.Linq;



public abstract class Account
{
    //fields
    private Customer customer;
    private decimal balance;
    private double interestRate;

    //constructor
    public Account(Customer customer, decimal balance, double interestRate)
    {
        this.CustomerOfBank = customer;
        this.Balance = balance;
        this.InterestRate = interestRate;
    }

    //properties
    public Customer CustomerOfBank
    {
        get
        {
            return this.customer;
        }
        set
        {
            
            this.customer = value;
        }
    }

    public decimal Balance
    {
        get
        {
            return this.balance;
        }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException();
            }
            this.balance = value;
        }
    }

    public double InterestRate
    {
        get
        {
            return this.interestRate;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException();
            }
            this.interestRate = value;
        }
    }


    public virtual double CalculateInterest(int numberOfMonths)
    {
        return numberOfMonths * this.InterestRate;
    }
}

