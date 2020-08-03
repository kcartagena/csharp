using System;
namespace Exercise11
{
    class Savings : Account
    {
        public override void Deposit(double depositAmnt)
        {
            double bonusAmnt = Math.Floor(depositAmnt / 100);

            if (bonusAmnt > 0)
            {
                Console.WriteLine($"You have earned ${bonusAmnt} of bonus bucks!");
                base.Deposit(depositAmnt + bonusAmnt);
            }
        }
    }
}
