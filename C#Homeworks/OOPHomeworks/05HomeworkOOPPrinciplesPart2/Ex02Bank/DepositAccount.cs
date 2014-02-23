using System;
using System.Linq;

  public class DepositAccount:Account,IDepositable,IWithdrawable
    {
      public DepositAccount(Customer customer, decimal balance, double interestRate)
          : base(customer, balance, interestRate)
      {

      }

      public void DepositMoney(decimal money)
      {
          this.Balance += money;
      }

      public void WithDraw(decimal money)
      {
          try
          {
              this.Balance -= money;
          }
          catch (Exception except)
          {
              Console.WriteLine(except.Message);
          }
      }

      public override double CalculateInterest(int numberOfMonths)
      {
          if (this.Balance > 0 && this.Balance <= 1000)
          {
              return 0;
          }
          else
          {
              return ((double)this.Balance * numberOfMonths * (this.InterestRate / 100));
          }
      }
    }

