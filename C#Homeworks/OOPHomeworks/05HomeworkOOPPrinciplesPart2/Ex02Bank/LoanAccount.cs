using System;
using System.Linq;


public class LoanAccount : Account,IDepositable
{
    public LoanAccount(Customer customer, decimal balance, double interestRate)
        : base(customer, balance, interestRate)
    {
    }
    public override double CalculateInterest(int numberOfMonths)
    {
        if (numberOfMonths <= 3 && this.CustomerOfBank == Customer.Individual)
        {
            return 0;
        }
        else if (numberOfMonths <= 2 && this.CustomerOfBank == Customer.Company)
        {
            return 0;
        }
        else if (this.CustomerOfBank == Customer.Company)
        {
            return (double)this.Balance * (this.InterestRate / 100) * (numberOfMonths - 2);
        }
        else
        {
            return (double)this.Balance * (this.InterestRate / 100) * (numberOfMonths - 3);
        }
    }

    public void DepositMoney(decimal money)
    {
        this.Balance += money;
    }
}

