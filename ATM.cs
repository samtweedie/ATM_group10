using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class ATM
    {
        //local referance to the array of accounts
        private Account[] ac;

        //this is a referance to the account that is being used
        private Account? activeAccount = null;

        // the atm constructor takes an array of account objects as a referance
        public ATM(Account[] ac)
        {
            this.ac = ac;
            //Console.WriteLine("hello from ATM");


            //this next section is the same as what we have in the form


            //// an infanite loop to keep the flow of controll going on and on
            //while (true)
            //{

            //    //ask for account number and store result in acctiveAccount (null if no match found)
            //    //activeAccount = this.findAccount();

            //    if (activeAccount != null)
            //    {
            //        //if the account is found check the pin 
            //        if (activeAccount.checkPin(this.promptForPin()))
            //        {
            //            //if the pin is a match give the options to do stuff to the account (take money out, view balance, exit)
            //            dispOptions();
            //        }
            //    }
            //    else
            //    {   //if the account number entered is not found let the user know!
            //        Console.WriteLine("no matching account found.");
            //    }

            //    //wipes all text from the console
            //    Console.Clear();
            //}


        }

        /*
         *    this method promts for the input of an account number
         *    the string input is then converted to an int
         *    a for loop is used to check the enterd account number
         *    against those held in the account array
         *    if a match is found a referance to the match is returned
         *    if the for loop completest with no match we return null
         * 
         */
        public Account findAccount(int input)
        {

            for (int i = 0; i < this.ac.Length; i++)
            {
                if (ac[i].getAccountNum() == input)
                {
                    return ac[i];
                }
            }

#pragma warning disable CS8603 // Possible null reference return.
            return null;
        }
        /*
         * 
         *  this jsut promt the use to enter a pin number
         *  
         * returns the string entered converted to an int
         * 
         */
        
        /*
         *  display balance of activeAccount and await keypress
         *  
         */
        private void dispBalance()
        {
            if (this.activeAccount != null)
            {
                Console.WriteLine(" your current balance is : " + activeAccount.getBalance());
                Console.WriteLine(" (prese enter to continue)");
                Console.ReadLine();
            }
        }

    }
}
