using System;
using System.Security.Principal;

namespace Module_17._6._6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Account regularAccount = new RegularAccount
            {
                Balance = 800
            };
            regularAccount.CalculateInterest();
            Console.WriteLine($"Проценты для обычного счета: {regularAccount.Interest}");

            Account salaryAccount = new SalaryAccount
            {
                Balance = 1500
            };
            salaryAccount.CalculateInterest();
            Console.WriteLine($"Проценты для зарплатного счета: {salaryAccount.Interest}");
        }
    }
}
