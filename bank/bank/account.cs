using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    public class account
    {
         private int i;
        public account(int amount)
        {
            i = amount;
        }
        public void Deposit(int amount)
        {
            i = i + amount;
        }
        public void WithDraw(int amount)
        {
            i = i - amount;
        }
        public int Balance()
        {
            return i;
        }
    }
}
