
//2.Write a class called LoanProcess with Loan_No, Customer Name, LoanAmount, EMI_Amount, Account_Balance as its members.
//Create a method calculate_EMI() for the LoanAmount, with the rate of interest as 13 % for a total of 3 years and store it in the EMI_Amount.
//The rest of the information to be passed through constructors.Write another function CheckBalance()which checks if the
//Account_Balance is less than the EMI_AMount.If yes then throw a custom exception.Display " Not Sufficient Balance to repay Loan" in the finally. Give explanatory comments.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class LoanException:ApplicationException
    {
        public LoanException(string msg):base(msg)
        {

        }
    }
    class LoanProcess
    {
        int Loanno;
        string CustomerName;
        double LoanAmount;
        double EMI_Amount;
        double AccBal;

        public LoanProcess(int ln,string CusName,double AB)
        {
            Loanno = ln;
            CustomerName = CusName;
            AccBal = AB;
            Console.WriteLine("Loan Number:{0}\nCustomer Name:{1}\nAccount Balance:{2}", Loanno, CusName, AccBal);
        }

        public void calculate_EMI()
        {
            Console.WriteLine("Enter Loan Amount");
            LoanAmount = Convert.ToDouble(Console.ReadLine());
            EMI_Amount = LoanAmount * 0.13 * 3;
            Console.WriteLine("EMI Amount ={0}", EMI_Amount);
        }
        public void CheckBalance()
        {
            if(AccBal<EMI_Amount)
            {
                throw (new LoanException("Not Sufficient Balance to Repay Loan"));
            }
            else
            {
                Console.WriteLine("LoanProcess Successfully Completed");
            }
        }
    }
    class LoanEg
    {
        static void Main()
        {
            LoanProcess lp = new LoanProcess(5768696, "Pavani", 20000);
            lp.calculate_EMI();
            try
            {
                lp.CheckBalance();
            }
            catch(LoanException e)
            {
                Console.WriteLine(e.Message);
            }
        }

}
}


/*OUTPUT
------------------------------------------------------------------
Test Case:1

Loan Number:5768696
Customer Name:Pavani
Account Balance:6000
Enter Loan Amount
20000
EMI Amount =7800
Not Sufficient Balance to Repay Loan
Press any key to continue . . .

Test Case:2

Loan Number:5768696
Customer Name:Pavani
Account Balance:20000
Enter Loan Amount
20000
EMI Amount =7800
LoanProcess Successfully Completed
Press any key to continue . . .*/


