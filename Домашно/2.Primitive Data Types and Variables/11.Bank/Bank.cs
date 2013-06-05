using System;

class Bank
{
    static void Main(string[] args)
    {
        string firstName = "Kiril";
        string secondName = "Stoyanov";
        string surName = "Tanushev";
        string fullName = firstName + " " + secondName + " " + surName;
        decimal balance = 5123.343m; 
        string bankname = "FIB";
        string IBAN = "BGNN FINV 9150 2343 3332";
        string BIC = "FINVBGSF";
        ulong CreditCardVisa = 1234567890123456;
        Console.WriteLine("Three names: {0}\nBalance: {1}\nnankname:{2}\nIBAN:{3}\nBIC:{4}\nCreditCardVisa:{5}",
            fullName, balance,bankname, IBAN, BIC, CreditCardVisa);
            
    }

}