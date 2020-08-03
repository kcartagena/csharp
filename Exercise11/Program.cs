using System;

namespace Exercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            Checking newCheckingAccount = new Checking();
            Savings newSavingsAccount = new Savings();

            byte selectAccount;
            byte selectAction;



            do
            {
                Console.WriteLine("Welcome! Please make a selection: ");
                Console.WriteLine("1 - Checking Account");
                Console.WriteLine("2 - Savings Account");
                Console.WriteLine("3 - Exit");

                selectAccount = Convert.ToByte(Console.ReadLine());
                Console.WriteLine();

                if (selectAccount != 3)
                {
                    do
                    {

                        Console.WriteLine("1 - Deposit");
                        Console.WriteLine("2 - Withdraw");
                        Console.WriteLine("3 - Check Balance");
                        Console.WriteLine("4 - Exit");

                        selectAction = Convert.ToByte(Console.ReadLine());
                        Console.WriteLine();

                      

                            if (selectAction == 1)
                            {
                                Console.Write("Enter the amount to deposit: ");
                                if (selectAccount == 1)
                                {
                                    newCheckingAccount.Deposit(Convert.ToDouble(Console.ReadLine()));

                                }
                                else if (selectAccount == 2)
                                {
                                    newSavingsAccount.Deposit(Convert.ToDouble(Console.ReadLine()));

                                }
                                Console.WriteLine();

                            }
                            else if (selectAction == 2)
                            {
                                Console.Write("Enter the amount to withdraw: ");
                                if (selectAccount == 1)
                                {
                                    newCheckingAccount.Withdraw(Convert.ToDouble(Console.ReadLine()));

                                }
                                else if (selectAccount == 2)
                                {
                                    newSavingsAccount.Withdraw(Convert.ToDouble(Console.ReadLine()));

                                }
                                Console.WriteLine();

                            }
                            else if (selectAction == 3)
                            {
                                if (selectAccount == 1)
                                {
                                    newCheckingAccount.CheckBalance();
                                }
                                else if (selectAccount == 2)
                                {
                                    newSavingsAccount.CheckBalance();
                                }
                                Console.WriteLine();

                            }
                        } while (selectAction != 4);
                    }
            } while (selectAccount != 3) ;            
        }
    }
}
