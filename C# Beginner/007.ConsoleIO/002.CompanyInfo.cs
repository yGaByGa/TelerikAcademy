//A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
//Write a program that reads the information about a company and its manager and prints it back on the console.

using System;

namespace _002.CompanyInfo
{
    class CompanyInfo
    {
        static void Main()
        {
            string companyName = Console.ReadLine();
            string companyAddress = Console.ReadLine();
            string phoneNumber = Console.ReadLine();
            string faxNumber = Console.ReadLine();
            string webSite = Console.ReadLine();
            string managerFName = Console.ReadLine();
            string managerLName = Console.ReadLine();
            string managerAge = Console.ReadLine();
            string managerPhone = Console.ReadLine();

            if (faxNumber.Length < 1)
            {
                faxNumber = "(no fax)";
            }

            Console.WriteLine(
@"{0}
Address: {1}
Tel. {2}
Fax: {3}
Web site: {4}
Manager: {5} {6} (age: {7}, tel. {8})
"
                , companyName, companyAddress, phoneNumber, faxNumber, webSite, managerFName, managerLName, managerAge, managerPhone);
        }
    }
}
