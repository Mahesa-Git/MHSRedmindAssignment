using System;
using System.Collections.Generic;

namespace MHSRedmindAssignment
{
    public class Program
    {
        private static List<int> ATMBalance = new() { 1000, 1000, 500, 500, 500, 100, 100, 100, 100, 100 };
        private readonly static List<int> WithdrawalOrder = new() { 1500, 700, 400, 1100, 1000, 700, 300 };
        static void Main(string[] args)
        {
            foreach (var amount in WithdrawalOrder)
            {
                bool result = ATMDepositCheck(amount);

                if (result)
                    Console.WriteLine($"Withdrawal of {amount} succeeded. Banknotes left: {ATMBalance.Count}");
                else
                    Console.WriteLine($"Withdrawal of {amount} failed. Banknotes left: {ATMBalance.Count}");
            }
            Console.ReadKey(true);
        }
        public static bool ATMDepositCheck(int amount)
        {
            ATMBalance.Sort();
            int sum = 0;
            var indexList = new List<int>();

            for (int i = ATMBalance.Count - 1; i >= 0; i--)
            {
                if (sum == amount)
                    break;

                if (ATMBalance[i] <= amount && ATMBalance[i] + sum <= amount)
                {
                    sum += ATMBalance[i];
                    indexList.Add(i);
                }
            }
            if (sum != amount)
                return false;

            foreach (var element in indexList)
                ATMBalance.RemoveAt(element);

            return true;
        }
    }
}
