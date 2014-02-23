using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


  public  class Program
    {
      static void Main()
      {
          Customer customer = Customer.Individual;
          DepositAccount account = new DepositAccount(customer, 1500, 5);
          
          Console.WriteLine(account.CalculateInterest(5));

          account.DepositMoney(2500);
          account.WithDraw(500);
          Console.WriteLine(account.Balance);
      }
      
    }

