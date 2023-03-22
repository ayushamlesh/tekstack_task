using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Question4_5
    {
        class bank
        {
            private double balanceIcici = 1000;
            private double balanceHdfc = 1000;


            public double Balicici
            {

                get { return balanceIcici; }
                set { balanceIcici = value; }
            }
            public double Balhdfc
            {
                get { return balanceHdfc; }
                set { balanceHdfc = value; }
            }
        }
        class Account
        {
            bank i = new bank();
            string bankName;
            string name;
            int account;
            double withdraw, dep, total;

            public void Deposit()
            {
                Console.WriteLine("Name of the Bank (ICICI or HDFC):");
                bankName = Console.ReadLine();
                Console.WriteLine("Name of the depositor :");
                name = Console.ReadLine();
                Console.WriteLine("Enter Account Number  :");
                account = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Deposit Amount :");
                dep = Convert.ToDouble(Console.ReadLine());
                bankName = bankName.ToUpper();
                if (bankName == "ICICI")
                {
                    total = i.Balicici + dep;

                }
                else
                {
                    total = i.Balhdfc + dep;
                }
                Console.WriteLine("------------------------------\n");
                Console.WriteLine("Name of the depositor : " + name);
                Console.WriteLine("Account Number: " + account);
                Console.WriteLine("Total Balance amount in the account of {0} is {1} : ", bankName, total);


            }

            class ICICIBank : Account
            {
                public void Widrawl()
                {
                    Console.WriteLine("Enter Account Name :");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter Account Number  :");
                    account = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Withdraw Amount :");
                    withdraw = Convert.ToDouble(Console.ReadLine());
                    bankName = bankName.ToUpper();
                    if (i.Balicici > 0)
                    {
                        total = i.Balicici - withdraw;
                        Console.WriteLine("------------------------------\n");
                        Console.WriteLine("Account Name : " + name);
                        Console.WriteLine("Account Number: " + account);
                        Console.WriteLine("After Withdraw Amount balnace is : " + total);

                    }

                }
            }

            class HDFCBank : Account
            {
                public void Widrawl()
                {
                    Console.WriteLine("Enter Account Name :");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter Account Number  :");
                    account = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Withdraw Amount :");
                    withdraw = Convert.ToDouble(Console.ReadLine());
                    bankName = bankName.ToUpper();
                    if (i.Balhdfc > 0)
                    {
                        total = i.Balicici - withdraw;
                        Console.WriteLine("------------------------------\n");
                        Console.WriteLine("Account Name : " + name);
                        Console.WriteLine("Account Number: " + account);
                        Console.WriteLine("After Withdraw Amount balnace is : " + total);
                    }
                }
            }


            static void Main(string[] args)
            {
                char agn;
                do
                {
                    Account obj = new Account();
                    int num;
                    Console.WriteLine("Please Select Any Function.");
                    Console.WriteLine("\nPress 1 for Deposit an Amount. \nPress 2 for Withdraw an Amount.");
                    num = Convert.ToInt32(Console.ReadLine());
                    switch (num)
                    {
                        case 1:
                            obj.Deposit();
                            break;
                        case 2:
                            obj.
                            break;
                        default:
                            Console.WriteLine("Invalid Selection!!!");
                            break;
                    }
                    Console.WriteLine("\nDo you want to continue this program? (y/n)");
                    agn = Convert.ToChar(Console.ReadLine());

                } while (agn == 'y');

                Console.ReadKey();
            }

            
        }
    }
}

