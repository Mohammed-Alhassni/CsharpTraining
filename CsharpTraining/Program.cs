namespace CsharpTraining
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Shared varibles
            int accountNumber = 0;
            string holderName = " ";
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
                ($"""

                === SYSTEM SETUP — Enter Account & Customer Data ===

                --- Account Profile ---
                1) Account Number (int) current: {accountNumber}
                2) Holder Name (string) current: {holderName}
                3) Balance (double) current: {avgBalance}
                4) Account Active? (bool) current: {isActive} [enter 1=yes / 0=no]
                5) Account Type (char) current: {accountType} [enter S / C / F]
                --- Customer Profile ---
                6) Employed? (bool) current: {isEmployed} [enter 1=yes / 0=no]
                7) Monthly Salary (double) current: {salary}
                8) Credit Score (int) current: {creditScore}
                9) Age (int) current: {age}
                --- Transaction Data ---
                10) Last Deposit Amount (double) current: {deposit}
                11) Last Withdrawal (double) current: {withdrawl}
                12) Annual Interest Rate (double) current: {annualRate} [e.g. 0.035 = 3.5%]
                13) Avg Monthly Balance (double) current: {avgBalance}
                0) Setup complete — launch Main Menu

                """);

            int option = 1;

            while (option != 0) 
            {
                Console.Write("Select option: ");
                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.Write("Enter Account number: ");
                        accountNumber = int.Parse(Console.ReadLine());
                        Console.WriteLine("Account Number set to: " + accountNumber);
                        break;
                    case 2:
                        Console.Write("Enter Holder Name: ");
                        holderName = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Holder Name set to: " + holderName);
                        break;
                    case 3:
                        Console.Write("Enter Balance: ");
                        balance = double.Parse(Console.ReadLine());
                        Console.WriteLine("Balance set to: " + balance);
                        break;
                    case 4:
                        Console.Write("Is Account Active? [enter 1=yes / 0=no]");
                        isActive = Convert.ToBoolean(int.Parse(Console.ReadLine()));
                        Console.WriteLine("Account is set to:" + isActive);
                        break;
                    case 5:
                        Console.Write("Enter Account type: [enter S / C / F]");
                        accountType = char.Parse(Console.ReadLine());
                        Console.WriteLine("Account Type set to: " + accountType);
                        break;
                    case 6:
                        Console.Write("Are you Employed? [enter 1=yes / 0=no]");
                        isEmployed = bool.Parse(Console.ReadLine());
                        Console.WriteLine("Employment set to: " + isEmployed);
                        break;
                    case 7:
                        Console.Write("Enter you Salary: ");
                        salary = double.Parse(Console.ReadLine());
                        Console.WriteLine("Salary set to: " + salary);
                        break;
                    case 8:
                        Console.Write("What is your Credit Score: ");
                        creditScore = int.Parse(Console.ReadLine());
                        Console.WriteLine("Credit Score set to: " + creditScore);
                        break;
                    case 9:
                        Console.Write("What is your Age: ");
                        age = int.Parse(Console.ReadLine());
                        Console.WriteLine("Age set to: " + age);
                        break;
                    case 10:
                        Console.Write("Enter Deposit amount: ");
                        deposit = double.Parse(Console.ReadLine());
                        Console.WriteLine("Deposit set to: " + deposit);
                        break;
                    case 11:
                        Console.Write("Enter withdrawl amount: ");
                        withdrawl = double.Parse(Console.ReadLine());
                        Console.WriteLine("Withdrawl set to: " + withdrawl);
                        break;
                    case 12:
                        Console.Write("Enter Annual Rate: [e.g. 0.035 = 3.5%]");
                        annualRate = double.Parse(Console.ReadLine());
                        Console.WriteLine("Annual Rate set to: " + annualRate);
                        break;
                    case 13:
                        Console.Write("Enter Average monthly balance: ");
                        avgBalance = double.Parse(Console.ReadLine());
                        Console.WriteLine("Average Balance set to: " + avgBalance);
                        break;
                    case 0:
                        Console.WriteLine("Setup complete. Launching Main Menu... \n");
                        mainMenu();
                        break;
                    default:
                    Console.WriteLine("Invalid option. Please choose 1–13 or 0 to finish.");
                        break;
                }
            }
            
            void mainMenu()
            {
                Console.WriteLine("This is the main menu");
            }
        }
    }
}
