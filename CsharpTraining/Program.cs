namespace CsharpTraining
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Shared varibles
            int accountNumber = 0;
            double balance = 0;
            bool isActive= false;
            char accountType = ' ';
            bool isEmployed = false;
            double salary = 0;
            int creditScore = 0;
            int age = 0;
            double deposit = 0;
            double withdrawl = 0;
            double annualRate = 0;
            double avgBalance = 0;

            Console.WriteLine
                ("""
                === SYSTEM SETUP — Enter Account & Customer Data ===

                --- Account Profile ---
                1) Account Number (int) current: 0
                2) Holder Name (string) current: [not set]
                3) Balance (double) current: 0.000 OMR
                4) Account Active? (bool) current: false [enter 1=yes / 0=no]
                5) Account Type (char) current: - [enter S / C / F]
                --- Customer Profile ---
                6) Employed? (bool) current: false [enter 1=yes / 0=no]
                7) Monthly Salary (double) current: 0.000 OMR
                8) Credit Score (int) current: 0
                9) Age (int) current: 0
                --- Transaction Data ---
                10) Last Deposit Amount (double) current: 0.000 OMR
                11) Last Withdrawal (double) current: 0.000 OMR
                12) Annual Interest Rate (double) current: 0.000 [e.g. 0.035 = 3.5%]
                13) Avg Monthly Balance (double) current: 0.000 OMR
                0) Setup complete — launch Main Menu
                """);

            int option = Convert.ToInt32(Console.ReadLine());

        }
    }
}
