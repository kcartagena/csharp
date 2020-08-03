using System;

namespace Exercise11
{
    abstract class Account
    {
        private double currentBalance;

        public Account()
        {
            currentBalance = 0.00;
        }

        public virtual void Deposit(double depositAmnt)
        {

            currentBalance += depositAmnt;
            Console.WriteLine($"A total of ${depositAmnt} has been deposited to your account.");
            CheckBalance();
        }

        public void Withdraw(double withdrawAmnt)
        {
            
            if (currentBalance >= withdrawAmnt)
            {
                currentBalance -= withdrawAmnt;
                Console.WriteLine($"A total of ${withdrawAmnt} has been withdrawn from your account.");
            }
            else
            {
                Console.WriteLine("You do not have enough funds to withdraw that amount!");
                
            }
            CheckBalance();
        }

        public void CheckBalance()
        {
            Console.WriteLine($"Your current balance is: ${currentBalance}.");
        }
     
    }
        
}
