using System.Security.Principal;
using System.Xml.Linq;

namespace Banking_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {

            welcome();

            BankAccount account = new BankAccount();

            string accountHolderName = "kopija";
            int accountNumber = 1996402125;
            decimal accountBalance = 00.0m;
            

        string bankName = "NKR_Bank";

            Console.WriteLine("Account Holder Name:" + accountHolderName);
            Console.WriteLine("Account Number:" + accountNumber);
            Console.WriteLine("Current Balance:" + account.accountBalance);
            Console.WriteLine(bankName);

            Console.WriteLine("Enter your account holder name");
            account. accountHolderName = Console.ReadLine();
            string nameuser = account.accountHolderName;
            Console.WriteLine("hello" + "" + nameuser + "!");
            Console.Write("Enter your opening amount");
          account.accountBalance = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter your account number");
           account.accountNumber= int.Parse(Console.ReadLine());
            


            Console.Clear();
            accountDetailas(account.accountHolderName, account.accountNumber, account.accountBalance);
            decimal Balance = account.accountBalance;
            Console.WriteLine($"Balance:{account.accountBalance}");

            int choice;

            do
            {
                Console.Clear();
                Console.WriteLine("----Banking Menu-----");
                Console.WriteLine("1.Account");
                Console.WriteLine("2.Cheak Balance");
                Console.WriteLine("3.Deposit");
                Console.WriteLine("4.Withdrew");
                Console.WriteLine("5. Transaction History");
                Console.WriteLine("6.Exit");
                Console.WriteLine("enter your choice(1to5)");


                choice = int.Parse(Console.ReadLine());



                switch (choice)
                {
                    case 1:
                        Console.WriteLine("you seleted: view account");
                        Console.WriteLine("AccountHolder:" + nameuser);
                        Console.WriteLine("AccountNumber:" + account.accountNumber);
                        break;
                    case 2:
                        Console.WriteLine("you seleted: view cheak balance");
                        Console.WriteLine($"your account balance:{account.accountBalance}");
                        break;

                    case 3:
                        account.DepositMoney(account);


                        break;
                    case 4:
                        account.WithdrawMoney(account);

                        break;
                     case 5:
                        Console.WriteLine(" Transaction History");
                    

                        if (account.transations.Count == 0)
                        {
                            Console.WriteLine("No transactions yet.");
                        }
                        else
                        {
                            foreach (var Tran in account.transations)
                            {
                                Console.WriteLine(Tran);
                            }
                        }
                        break;
                        
                    case 6:
                        Console.WriteLine("you seleted:exit");
                        Console.WriteLine("Thank you");
                        break;
                    default:
                        Console.WriteLine("invalid choice! you choice (1to6)");
                        break;
                }
                if (choice != 6)
                {
                    Console.WriteLine("Enter the continue");
                    Console.ReadLine();

                }
            } while (choice != 6);


        }
        public static void welcome()
        {
            Console.WriteLine("==========================================");
            Console.WriteLine("               NKR_Bank");
            Console.WriteLine("==========================================");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Welcome to NKR_Bank");
            Console.WriteLine("----------------------------------------");
        }
        public static void accountDetailas(string Name, int accountNumber, decimal accountBalance)
        {
            Console.WriteLine($"Account Details\n1.{Name}\n2.{accountNumber}\n3.{accountBalance}");

        }



    }
    public class BankAccount
    {
        public string accountHolderName ;
        public int accountNumber;
        public decimal accountBalance; //{ get; private set; }
        public decimal depositAmount; 
            //{ get; private set; }
        public decimal widthdrowAmount; //{ get; private set; }
        
        

        public  void DepositMoney(BankAccount account)
        {
            Console.WriteLine("you seleted: deposit");
            Console.WriteLine("Enter amout to deposit");
            depositAmount = decimal.Parse(Console.ReadLine());
            if (depositAmount > 0)
            {
               account.accountBalance += depositAmount;
                Console.WriteLine($"deposit is successfully!");
                account.transations.Add($"Deposited:{depositAmount}on{DateTime.Now}");
                Console.WriteLine($"updated balance:{account.accountBalance}");
            }
            else
            {
                Console.WriteLine("invalid amount");


            }
            

        }


        public  void WithdrawMoney(BankAccount account)
        {
            Console.WriteLine("you seleted:widthdrow");
            Console.WriteLine("Enter amout to widthdrow");
            widthdrowAmount = decimal.Parse(Console.ReadLine());
            if (widthdrowAmount > 0 && widthdrowAmount <= account.accountBalance)
            {
                account.accountBalance -= widthdrowAmount;
                Console.WriteLine($"widthdrow is successfully!");
                account.transations.Add($"Widthdrawn:{widthdrowAmount} on {DateTime.Now}");
                Console.WriteLine($"remaiding balance:{account.accountBalance}");

            }
            else
            {
                Console.WriteLine("widthdrow is invaild");
                Console.WriteLine("cheak amount and balance");
            }

        }
        public List <string> transations=new List<string>();

    }
}

      

            
            
        






