using System;
using System.Linq;

public class MortgageAccount : Account,IDepositable
{
    public MortgageAccount(Customer customer, decimal balance, double interestRate)
        : base(customer, balance, interestRate)
    {
    }
    public override double CalculateInterest(int numberOfMonths)
    {
        if (numberOfMonths <= 12 && this.CustomerOfBank == Customer.Company)
        {
            return ((double)this.Balance * (this.InterestRate / 100) * numberOfMonths) * 0.5;
        }
        else if (numberOfMonths <= 6 && this.CustomerOfBank == Customer.Individual)
        {
            return 0;
        }
        else if (this.CustomerOfBank == Customer.Company)
        {
            return ((double)this.Balance * (this.InterestRate / 100 / 2) * 12) + (numberOfMonths * (this.InterestRate / 100) * (numberOfMonths - 12));
        }
        else
        {
            return (double)this.Balance * (this.InterestRate / 100) * (numberOfMonths - 6);
        }
       
    }

      public void DepositMoney(decimal money)
      {
          this.Balance += money;
      }
    }

