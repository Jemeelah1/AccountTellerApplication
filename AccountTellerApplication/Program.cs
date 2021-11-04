using System;

namespace AccountTellerApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //brings 2000
            //rate is 5%
            //2000 + 5%(2000)
            //2100 + 5%(2100) = 2205

            //initial money 2000...get from user
            //rate..set ourselves... savings 5% current 10%
            //type of account ...get from user

            //calculate interest ..software(us)
            //to know which rate to give user
            //show the user his/her gross money

            BankTeller Horace = new BankTeller();
            Horace.Registration();
            Horace.DisplayToUser();
        }
    }

    class BankTeller
    {
        public string AccountType { get; set; }
        public double Amount { get; set; }
        private double SavingsRate = 5.2 / 100;
        private double CurrentRate = 10.5 / 100;
        public string Fullname { get; set; }
        public string Gender { get; set; }


        public void Registration()
        {
            //return number of Registration
            Console.WriteLine("Please enter your Fullname");
            Fullname = Console.ReadLine();
            Console.WriteLine("Please enter your Gender");
            Gender = Console.ReadLine();
            Console.WriteLine("Enter your preferred account type: ");
            AccountType = Console.ReadLine();
            Console.WriteLine("Enter your amount: ");
            Amount = double.Parse(Console.ReadLine());

        }

        public double SelectRate(string accountType)
        {
            double chosenRate;
            if (accountType == "savings")
            {
                chosenRate = SavingsRate;
                return chosenRate;
            }
            else if (accountType == "current")
            {
                chosenRate = CurrentRate;
                return chosenRate;
            }
            else
            {
                Console.WriteLine("Enter correct information");
                Console.ReadLine();
            }
            return 0.00;
        }




        public double MonthlyTotal6()
        {
            double interest;
            double vat = 7.5 / 100;
            double monthEndAmount = Amount;
            for (int i = 0; i < 6; i++) 
            {
                interest = SelectRate(AccountType) * monthEndAmount;
                interest = interest - (vat * interest);
                monthEndAmount = monthEndAmount + interest;
            }
            return Math.Round(monthEndAmount,2);
        }

        public double MonthlyTotal9()
        {
            double interest;
            double vat = 7.5 / 100;
            double monthEndAmount = Amount;
            for (int i = 0; i < 9; i++) 
            {
                interest = SelectRate(AccountType) * monthEndAmount;
                interest = interest - (vat * interest);
                monthEndAmount = monthEndAmount + interest;
            }
            return Math.Round(monthEndAmount, 2);

        }

        public double MonthlyTotal12()
        {
            double interest;
            double vat = 7.5 / 100;
            double monthEndAmount = Amount;
            for (int i = 0; i < 12; i++) 
            {
                interest = SelectRate(AccountType) * monthEndAmount;
                interest = interest - (vat * interest);
                monthEndAmount = monthEndAmount + interest;
            }
            return Math.Round(monthEndAmount, 2);
        }

        public double MonthlyTotal24()
        {
            double interest;
            double vat = 7.5 / 100;
            double monthEndAmount = Amount;
            for (int i = 0; i < 24; i++) 
            {
                interest = SelectRate(AccountType) * monthEndAmount;
                interest = interest - (vat * interest);
                monthEndAmount = monthEndAmount + interest;
            }
            return Math.Round(monthEndAmount, 2);
        }

        public double MonthlyTotal60()
        {
            double interest;
            double vat = 7.5 / 100;
            double monthEndAmount = Amount;
            for (int i = 0; i < 60; i++) 
            {
                interest = SelectRate(AccountType) * monthEndAmount;
                interest = interest - (vat * interest);
                monthEndAmount = monthEndAmount + interest;
            }
            return Math.Round(monthEndAmount, 2);
        }

        public void DisplayToUser()
        {
            Console.WriteLine("Your total money after 6 months will be " + MonthlyTotal6());
            Console.WriteLine("Your total money after 9 months will be " + MonthlyTotal9());
            Console.WriteLine("Your total money after 12 months will be " + MonthlyTotal12());
            Console.WriteLine("Your total money after 24 months will be " + MonthlyTotal24());
            Console.WriteLine("Your total money after 60 months will be " + MonthlyTotal60());
        }



    }
}
