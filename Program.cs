using System.Runtime.CompilerServices;

namespace ATM
{
    internal class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        //[STAThread]

        private Account[] ac = new Account[3];
        private ATM atm;

        public Program()
        {
            ac[0] = new Account(300, 1111, 111111);
            ac[1] = new Account(750, 2222, 222222);
            ac[2] = new Account(3000, 3333, 333333);

            atm = new ATM(ac);

            Thread t1 = new Thread(() => RunForm(atm));
            Thread t2 = new Thread(() => RunForm(atm));
            Thread t3 = new Thread(() => RunForm(atm));
            t1.Start();
            t2.Start();
            t3.Start();

        }

        private static void RunForm(ATM atm)
        {
            Application.Run(new ATMForm(atm));
        }

        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            ApplicationConfiguration.Initialize();
            new Program();

        } 

    }
}