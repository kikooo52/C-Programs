using System;


class FirmInfo
{
    static void Main(string[] args)
    {
        Console.Write("Firm name: ");
        string companyName = Console.ReadLine();
        Console.Write("Firm address: ");
        string companyAddress = Console.ReadLine();
        Console.Write("Firm phone number: ");
        string companyPhoneNumber = Console.ReadLine();
        Console.Write("Firm fax number: ");
        string companyFaxNumber = Console.ReadLine();
        Console.Write("Firm web site: ");
        string companyWebSite = Console.ReadLine();
        Console.WriteLine();

        Console.Write("Manager first name: ");
        string managerFirstName = Console.ReadLine();
        Console.Write("Manager last name: ");
        string managerLastName = Console.ReadLine();
        Console.Write("Manager age: ");
        string managerAge = Console.ReadLine();
        Console.Write("Manager phone number: ");
        string managerPhone = Console.ReadLine();

       Console.WriteLine();
       Console.WriteLine();

       Console.WriteLine("\t\tFIRM INFORMATION");
       Console.WriteLine("\t\t***********************************************************");
       Console.WriteLine("\t\tFirm name: {0}", companyName);
       Console.WriteLine("\t\tFirm address: {0}", companyAddress);
       Console.WriteLine("\t\tFirm phone number: {0}", companyPhoneNumber);
       Console.WriteLine("\t\tFirm fax number: {0}", companyFaxNumber);
       Console.WriteLine("\t\tFirm web site: {0}", companyWebSite);

       Console.WriteLine();
       Console.WriteLine();

       Console.WriteLine("\t\tMANAGER INFORMATION");
       Console.WriteLine("\t\t***********************************************************");
       Console.WriteLine("\t\tManager first name: {0}", managerFirstName);
       Console.WriteLine("\t\tManager last name: {0}", managerLastName);
       Console.WriteLine("\t\tManager age: {0}", managerAge);
       Console.WriteLine("\t\tManager phone number: {0}", managerPhone);
    }
}

