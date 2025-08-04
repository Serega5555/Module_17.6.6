using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_17._6._6
{
    public class SalaryAccount: Account
    {
        public override void CalculateInterest()
        {
            Interest = Balance * 0.5;
        }
    }
}
