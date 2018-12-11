using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cede_Dotnet_CSharp_POO.relations
{
    public class Account
    {
        public Money MyMoney { get; set; }

        public string Type { get; set; }

        public string Owner { get; set; }

        public Account(Money myMoney)
        {
            MyMoney = myMoney;
        }        

        public void Deposit(double amountValue)
        {
            MyMoney.Amount += amountValue;
        }

        public void Withdraw(double amountValue)
        {
            MyMoney.Amount -= amountValue;
        }
    }
}
