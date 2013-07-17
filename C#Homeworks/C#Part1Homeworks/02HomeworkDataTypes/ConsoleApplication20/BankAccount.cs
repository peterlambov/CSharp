using System;

class BankAccount
{
    static void Main()
    {
        string firstName = "Ivan";
        string middleName = "Georgiev";
        string lastName = "Ivanov";
        ulong balance = 7890222344;
        string bankName = "ProCredit";
        string iban = "cH344657k5KL67";
        string bic = "PrCrB";
        ulong creditCard1 = 2268457938298;
        ulong creditCard2 = 9232953435382;
        ulong creditCard3 = 8749306890793;
        Console.WriteLine("{0} {1} {2}", firstName, middleName, lastName);
        Console.WriteLine("Balance:" + balance + "\n" + "Bank name:" + bankName + "\n" + "IBAN:" + iban + "\n" + "BIC code:" + bic);
        Console.WriteLine("Creditcard 1:" + creditCard1 + "\n" + "Creditcard 2:" + creditCard2 + "\n" + "Creditcard 3:" + creditCard3);
    }
}