using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_17._6._6
{
    public abstract class Account
    {
        public double Balance { get; set; }
        public double Interest { get; protected set; }
        public abstract void CalculateInterest();
    }
}
