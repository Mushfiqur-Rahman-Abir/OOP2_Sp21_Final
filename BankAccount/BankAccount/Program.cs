using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            /*CurrentAccount a1 = new CurrentAccount("Mushfiqur Abir","12345",20000);
            CurrentAccount a2 = new CurrentAccount("Mahabubur Sabir","67890",10000);
            a1.ShowInfo();
            a2.ShowInfo();
            Console.WriteLine("************************");
            a1.Withdraw(5000);
            a1.Transfer(a2, 5000);
            Console.WriteLine("************************");
            a1.ShowInfo();
            a2.ShowInfo();*/

            Account a1 = new SavingsAccount("ABIR","12345",50000);
            Account a2 = new CurrentAccount("ABIR","67890",50000);
            Account a3 = new SavingsAccount("ABIR SABIR", "112233", 5000);
            Account a4 = new FixedAccount("ABIR", "99999", 100000, 5, 2015);

            /*a1.Withdraw(49600);
            a2.Withdraw(49600);
            a1.ShowInfo();
            a2.ShowInfo();*/

            Customer c = new Customer();
            c.AddAccounts(a1,a2,a3,a4);
            //c.ShowAccDetails();
            var acc = c.GetAccount("112233");
            acc.Withdraw(4600);
        }
    }
}
