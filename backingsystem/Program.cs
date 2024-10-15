using System.Text.RegularExpressions;

namespace backingsystem
{
    class Account
    {
        // feilds 
        private int _Account_number;
        private string _Name;
        private Decimal _Balance;

        public Account()
        {
            
        }
        Account(int Account_number, string Name ,Decimal Balance)
        {
            this.Account_number = Account_number;
            this.Name = Name;
            this.Balance = Balance;
        }

        
        //propites to fields 
        public int Account_number
        {
            get
            {
                return _Account_number;
            }
            set
            {
                _Account_number = value;
            }
        }
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                if (value.Length >= 4 && !Regex.IsMatch(value, @"[@#$^&*!]"))
                {
                    _Name = value;
                }
                else
                {
                    Console.WriteLine("please enter valid name ");
                }
               
            }
        }
        public Decimal Balance
            {
            get 
            { 
                return _Balance;
            }
            private set 
            { 
                _Balance = value; 
            }

            }

        // methods 
        public void Deposite()
        {
            Console.WriteLine("enter your deposite amount ");
            int Amount = int.Parse(Console.ReadLine());
            if (Amount > 0)
            {
                this.Balance += Amount;
                Console.WriteLine("this is your new balance{0}", Balance);
            }
            else
            {
                Console.WriteLine("please enter the correct amount");
            }
        }
        public void Withdraw()
        {
            Console.WriteLine("enter the withdraw amount ");
            int Amount = int.Parse(Console.ReadLine());
            if (this.Balance < 500)
            {
                this.Balance -= Amount;
                Console.WriteLine("After withdraw your balance {0} ", Balance);
                Console.WriteLine("you inefficient funds to withdraw");
            }
            else
            {
                Console.WriteLine("you inefficient funds to withdraw");
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Account a = new Account();
            Console.WriteLine("please enter your Account number:");
            a.Account_number =int.Parse( Console.ReadLine());
            Console.WriteLine("please enter your Name");
            a.Name = Console.ReadLine();
            Console.WriteLine("{0} hi \n hope u have great day",a.Name);
            a.Deposite();
            a.Withdraw();
        }
    }
}
