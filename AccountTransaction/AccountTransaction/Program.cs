using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountTransaction
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account("Abir","1234",50000);
            Account a2 = new Account("Sabir","5678",10000);
            a1.showInfo();
            a2.showInfo();
            a1.Withdraw(1000);
            a1.Deposit(10000);
            a1.Transfer(a2, 5000);
            a1.showInfo();
            a2.showInfo();
            Transaction t1 = new Transaction(a1,a2,7000,"Business perpose");
            t1.showInfo();
        }
    }
}
