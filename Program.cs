using System;

namespace ooPFinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int? selection;
            int? Typeselection;
            int? operSelection;
            int position = 1;
            //List<BankAccount> SaveAccount = new List<BankAccount>();
            //SaveAccount[] NewSaccounts = new SaveAccount[10];
            //BankAccount[] NewAccounts = new BankAccount[10];
            do
            {
                Console.WriteLine("1-Create Account");
                //Console.WriteLine("2-Show Accounts");
                Console.WriteLine("2-close");
                selection = Convert.ToInt32(Console.ReadLine());
                if (selection == 2)
                { break; }
                //if(selection==2)
                //{
                //    foreach (var item in NewAccounts)
                //    {
                //        if (item == null)
                //        {
                //            Console.WriteLine("There's No More Accounts");
                //            break;
                //        }
                //        else
                //        {
                //            Console.WriteLine("Accounts Num :"+" "+ item.AccNum +" "+"Account Balance :"+" "+ item.balance);
                //        }
                //    }                

                //}
                do
                {

                    if (selection == null || selection <= 0 || selection > 2)
                    { Console.WriteLine("Invalid Selection"); }
                    else
                        do
                        {
                            Console.WriteLine("Choose Account Type");
                            Console.WriteLine("1-Saving Account");
                            Console.WriteLine("2-checking Account");
                            Typeselection = Convert.ToInt32(Console.ReadLine());
                            if (Typeselection > 2 || Typeselection <= 0)
                                Console.WriteLine("invalid Selection");

                            else
                                switch (Typeselection)
                                {
                                    case 1:
                                        int? AccountN;
                                        decimal? _balance;
                                        do
                                        {
                                            Console.WriteLine("Enter Account Number");
                                            AccountN = Convert.ToInt32(Console.ReadLine());
                                            Console.WriteLine("Enter Your First Balance");
                                            _balance = Convert.ToDecimal(Console.ReadLine());
                                        }
                                        while (AccountN == null || _balance == null);
                                        //foreach (var AddItem in NewAccounts)
                                        //{
                                        //    if (AddItem != null)
                                        //    {
                                        //        if (AddItem.AccNum == AccountN)
                                        //        { Console.WriteLine("There is Account With This ID Try Again");
                                        //            break;
                                        //        }
                                        //    }
                                        //}
                                        SaveAccount NewSaveAccount = new SaveAccount(AccountN, _balance);
                                        //NewAccounts[position] = NewSaveAccount;
                                        //position++;

                                        //SaveAccount.Add(NewSaveAccount);
                                        Console.WriteLine("Saving Account Has been Created Successfully");
                                        do
                                        {
                                            Console.WriteLine("Choose Operation To Do");
                                            Console.WriteLine("1-Deposit");
                                            Console.WriteLine("2-Withdraw");
                                            Console.WriteLine("3-close");
                                            operSelection = Convert.ToInt32(Console.ReadLine());
                                            if (operSelection == 1)
                                            {
                                                decimal? debosValue;
                                                Console.WriteLine("Enter Your Value");
                                                debosValue = Convert.ToDecimal(Console.ReadLine());
                                                NewSaveAccount.deposit(debosValue);
                                                NewSaveAccount.LogMsg("Succesfully Operation");
                                            }
                                            else if (operSelection == 2)
                                            {
                                                decimal? withValue;
                                                Console.WriteLine("Enter Value To Withdarw");
                                                withValue = Convert.ToDecimal(Console.ReadLine());
                                                NewSaveAccount.WithDraw(withValue);
                                            }
                                            else if (operSelection == 3)
                                            { break; }
                                        }
                                        while (operSelection == null || operSelection > 3 || operSelection <= 0 || operSelection < 3);
                                        // start Deposite From Here
                                        break;
                                    case 2:
                                        int? CheckAccountN;
                                        decimal? _Checkbalance;

                                        do
                                        {
                                            Console.WriteLine("Enter Account Number");
                                            CheckAccountN = Convert.ToInt32(Console.ReadLine());
                                            Console.WriteLine("Enter Your First Balance");
                                            _Checkbalance = Convert.ToDecimal(Console.ReadLine());
                                        }
                                        while (CheckAccountN == null || _Checkbalance == null);

                                        ChakingAccount NewCheckAccount = new ChakingAccount(CheckAccountN, _Checkbalance);
                                        Console.WriteLine("Checking Account Has been Created Successfully");
                                        do
                                        {
                                            Console.WriteLine("Choose Operation To Do");
                                            Console.WriteLine("1-Deposit");
                                            Console.WriteLine("2-Withdraw");
                                            Console.WriteLine("3-close");
                                            operSelection = Convert.ToInt32(Console.ReadLine());
                                            if (operSelection == 1)
                                            {
                                                decimal? debosValue;
                                                Console.WriteLine("Enter Your Value");
                                                debosValue = Convert.ToDecimal(Console.ReadLine());
                                                NewCheckAccount.deposit(debosValue);
                                                //NewCheckAccount.LogMsg("Succesfully Operation");
                                            }
                                            else if (operSelection == 2)
                                            {
                                                decimal? withValue;
                                                Console.WriteLine("Enter Value To Withdarw");
                                                withValue = Convert.ToDecimal(Console.ReadLine());
                                                NewCheckAccount.WithDraw(withValue);
                                                //NewCheckAccount.LogMsg("Succesfully Operation");
                                            }
                                            else if (operSelection == 3)
                                            { break; }
                                        }
                                        while (operSelection == null || operSelection > 3 || operSelection <= 0 || operSelection < 3);
                                        break;
                                }
                        }
                        while (Typeselection == null || Typeselection <= 0 || Typeselection > 2);
                }
                while (selection == null || selection <= 0 || selection > 2);
            }
            while (true);



            //int ArrNum = 0;
            //SaveAccount FirstAcc = new SaveAccount();
            //SaveAccount[] SaveAccounts = new SaveAccount[100];
            //FirstAcc.AccNum = 1;
            //FirstAcc.balance = 20000;


            //foreach (var item in SaveAccounts)
            //{   if(item==null) 
            //    {
            //        SaveAccounts[ArrNum] = FirstAcc;
            //        ArrNum += 1;
            //        break;
            //    }
            //  else  if (FirstAcc.AccNum == item.AccNum)
            //    { 
            //    Console.WriteLine("AccNum Alraedy Exist");
            //    break;
            //    }
            //    else
            //        SaveAccounts[ArrNum] = FirstAcc;
            //    ArrNum += 1;
            //}

            Console.ReadKey();
        }
    }
    //////////////////////////////Abstraction Using Abstract Class
    public abstract class BankAccount
    {
        public int? AccNum;
        public decimal? balance;
        public BankAccount() { }
        public abstract void deposit(decimal? Amount);
        public abstract void WithDraw(decimal? Amount);
        public abstract void LogMsg(string msg);
    }
    public class SaveAccount : BankAccount
    {
        public SaveAccount() { }
        public SaveAccount(int? accnum, decimal? _balance)
        {
            base.AccNum = accnum;
            base.balance = _balance;
        }
        public const decimal MaxValue = 500;
        public override void LogMsg(string msg)
        {
            string NowDate = DateTime.Now.ToString("MM/dd/yyyy");
            Console.WriteLine(NowDate + " " + msg);
            Console.WriteLine("AccountInfo" + " " + "AccNum" + " " + AccNum + "AccountBalance" + " " + balance);
        }
        public override void deposit(decimal? Amount)
        {
            if (Amount < 0)
                LogMsg("cannot insert negative value");
            else if (Amount == 0)
                LogMsg("rejected");
            else
                balance += Amount;
            LogMsg("Accepted");
        }
        public override void WithDraw(decimal? Amount)
        {
            if (Amount < 0)
                LogMsg("Can't Withdraw Negative Value");
            else if (Amount == 0)
                LogMsg("Rejected");
            else if (Amount > MaxValue)
                LogMsg("Can't Withdraw more Than MaxValue");
            else
                balance -= Amount;
            LogMsg("Accepted");

        }
    }
    public class ChakingAccount : BankAccount
    {
        public ChakingAccount() { }
        public ChakingAccount(int? accnum, decimal? _balance)
        {
            base.AccNum = accnum;
            base.balance = _balance;
        }
        public const decimal MaxValue = 2000;
        public override void LogMsg(string msg)
        {
            string NowDate = DateTime.Now.ToString("MM/dd/yyyy");
            Console.WriteLine(NowDate + " " + msg);
            Console.WriteLine("AccountInfo" + " " + "AccNum" + " " + AccNum + "AccountBalance" + " " + balance);
        }
        public override void deposit(decimal? Amount)
        {
            if (Amount < 0)
                LogMsg("cannot insert negative value");
            else if (Amount == 0)
                LogMsg("rejected");
            else
                balance += Amount;
            LogMsg("Accepted");
        }
        public override void WithDraw(decimal? Amount)
        {
            if (Amount < 0)
                LogMsg("Can't Withdraw Negative Value");
            else if (Amount == 0)
                LogMsg("Rejected");
            else if (Amount > MaxValue)
                LogMsg("Can't Withdraw more Than MaxValue");
            else if (Amount > balance)
                LogMsg("Can't Withdraw more Than YourBalance");
            else
                balance -= Amount;
            LogMsg("Accepted");

        }
    }






    //////////////////////////////Abstraction Using interFace
    interface IbankAccount
    {
        public abstract void deposit(decimal Amount);
        public abstract void WithDraw(decimal Amount);
        public abstract void LogMsg(string Msg);
    }

    public class ISaveAccount : IbankAccount
    {
        public decimal AccBalance;
        public int AccountNum;
        public ISaveAccount()
        {
            AccBalance = 0;
            AccountNum = 1;
        }
        public const decimal MaxValue = 500;
        public void LogMsg(string msg)
        {
            string NowDate = DateTime.Now.ToString("MM/dd/yyyy");
            Console.WriteLine(NowDate + " " + msg);
            Console.WriteLine("AccountInfo" + " " + "AccNum" + " " + AccountNum + "AccountBalance" + " " + AccBalance);
        }
        public void deposit(decimal Amount)
        {
            if (Amount < 0)
                LogMsg("cannot insert negative value");
            else if (Amount == 0)
                LogMsg("rejected");
            else
                AccBalance += Amount;
            LogMsg("Accepted");
        }
        public void WithDraw(decimal Amount)
        {
            if (Amount > 0)
                LogMsg("Can't Withdraw Negative Value");
            else if (Amount == 0)
                LogMsg("Rejected");
            else if (Amount > MaxValue)
                LogMsg("Can't Withdraw more Than MaxValue");
            else
                AccBalance -= Amount;
            LogMsg("Accepted");

        }
    }
    public class IChakingAccount : IbankAccount
    {
        public decimal AccBalance;
        public int AccountNum;
        public IChakingAccount()
        {
            AccBalance = 0;
            AccountNum = 1;
        }
        public const decimal MaxValue = 2000;
        public void LogMsg(string msg)
        {
            string NowDate = DateTime.Now.ToString("MM/dd/yyyy");
            Console.WriteLine(NowDate + " " + msg);
            Console.WriteLine("AccountInfo" + " " + "AccNum" + " " + AccountNum + "AccountBalance" + " " + AccBalance);
        }
        public void deposit(decimal Amount)
        {
            if (Amount < 0)
                LogMsg("cannot insert negative value");
            else if (Amount == 0)
                LogMsg("rejected");
            else
                AccBalance += Amount;
            LogMsg("Accepted");
        }
        public void WithDraw(decimal Amount)
        {
            if (Amount > 0)
                LogMsg("Can't Withdraw Negative Value");
            else if (Amount == 0)
                LogMsg("Rejected");
            else if (Amount > MaxValue)
                LogMsg("Can't Withdraw more Than MaxValue");
            else
                AccBalance -= Amount;
            LogMsg("Accepted");

        }
    }



}

