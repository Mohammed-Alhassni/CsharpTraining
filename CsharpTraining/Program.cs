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
                    1) Account Number                       current: {accountNumber}
                    2) Holder Name                          current: {holderName}
                    3) Balance                              current: {balance}
                    4) Account Active? [enter 1=yes / 0=no] current: {isActive}
                    5) Account Type [enter S / C / F]       current: {accountType}

                    --- Customer Profile ---
                    6) Employed? [enter 1=yes / 0=no]       current: {isEmployed}
                    7) Monthly Salary                       current: {salary}
                    8) Credit Score                         current: {creditScore}
                    9) Age                                  current: {age}

                    --- Transaction Data ---
                    10) Last Deposit Amount                 current: {deposit}
                    11) Last Withdrawal                     current: {withdrawl}
                    12) Annual Interest Rate [e.g. 0.035]   current: {annualRate}
                    13) Avg Monthly Balance                 current: {avgBalance}

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
                        Console.Write("Is Account Active [enter 1=yes / 0=no]: ");
                        isActive = Convert.ToBoolean(int.Parse(Console.ReadLine()));
                        Console.WriteLine("Account is set to:" + isActive);
                        break;
                    case 5:
                        Console.Write("Enter Account type [enter S / C / F]: ");
                        accountType = char.Parse(Console.ReadLine());
                        Console.WriteLine("Account Type set to: " + accountType);
                        break;
                    case 6:
                        Console.Write("Are you Employed [enter 1=yes / 0=no]: ");
                        isEmployed = Convert.ToBoolean(int.Parse(Console.ReadLine()));
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
                        Console.Write("Enter Annual Rate [e.g. 0.035 = 3.5%]: ");
                        annualRate = double.Parse(Console.ReadLine());
                        Console.WriteLine("Annual Rate set to: " + annualRate);
                        break;
                    case 13:
                        Console.Write("Enter Average monthly balance: ");
                        avgBalance = double.Parse(Console.ReadLine());
                        Console.WriteLine("Average Balance set to: " + avgBalance);
                        break;
                    case 0:
                        Console.WriteLine("Setup complete. Launching Main Menu...");
                        mainMenu();
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please choose 1–13 or 0 to finish.");
                        break;
                }
            }

            void mainMenu()
            {
                Console.WriteLine($"""

                        === NATIONAL BANK OF OMAN ===

                        Unified Banking System v1.0
                        --- System Setup complete ---

                        Customer : {holderName}
                        Balance : {balance} OMR

                        1) ATM Services
                        2) Account Management
                        3) Loan Services
                        4) Currency Exchange
                        5) Credit Card Portal
                        6) Branch Services
                        7) Reports & Admin
                        0) Exit

                    """);


                int moduleOption = 1;
                while (moduleOption != 0)
                {
                    Console.Write("Select: ");
                    moduleOption = Convert.ToInt32(Console.ReadLine());

                    switch (moduleOption)
                    {
                        case 1:
                            atmServices();
                            break;
                        case 2:
                            accountManagment();
                            break;
                        case 3:
                            Console.WriteLine("Loan Services");
                            break;
                        case 4:
                            Console.WriteLine("Currency Exchange");
                            break;
                        case 5:
                            Console.WriteLine("Credit Card Portal");
                            break;
                        case 6:
                            Console.WriteLine("Branch Services");
                            break;
                        case 7:
                            Console.WriteLine("Reports & Admin");
                            break;
                        case 0:
                            Environment.Exit(1);
                            break;
                        default:
                            Console.WriteLine("Invalid option. Please choose 1–8 or 0 to Exit.");
                            break;
                    }
                }
            }

            void atmServices()
            {
                const string correctPin = "4821";
                int maxAttempts = 3;

                Console.WriteLine("""

                        === ATM Services ===

                        1) ATM Welcome & Display
                        2) Account Data Viewer
                        3) ATM PIN Validation
                        4) ATM Receipt Printer
                        0) Return to Main Menu

                    """);

                int serviceOption = 1;

                while (serviceOption != 0)
                {
                    Console.Write("Select: ");
                    serviceOption = Convert.ToInt32(Console.ReadLine());

                    switch (serviceOption)
                    {
                        case 1:
                            welcomeAndDisplay();
                            break;
                        case 2:
                            accountDataViewer();
                            break;
                        case 3:
                            atmPinValidation();
                            break;
                        case 4:
                            atmReceiptPrinter();
                            break;
                        case 0:
                            mainMenu();
                            break;
                        default:
                            Console.WriteLine("Invalid option. Please choose 1–4 or 0 to retrun to main menu.");
                            break;
                    }
                }

                void welcomeAndDisplay()
                {
                    Console.WriteLine("""
                                          Welcome to National Bank of Oman
                                                      
                                          1) Bank Info
                                          2) Branch Info
                                          3) Opening Hours
                                          0) Back
                                          
                                      """);
                    int option = 1;
                    while (option != 0)
                    {
                        Console.Write("Select: ");
                        option = Convert.ToInt32(Console.ReadLine());
                        switch (option)
                        {
                            case 1:
                                Console.WriteLine("Bank Name: National Bank of Oman");
                                Console.WriteLine("Since 2005");
                                break;
                            case 2:
                                Console.WriteLine("Branch Name: Muscat National Bank of Oman");
                                Console.WriteLine("Muscat");
                                break;
                            case 3:
                                Console.WriteLine("Weekday hours: 7-5");
                                Console.WriteLine("Weekend hours: 9-3");
                                break;
                            case 0:
                                atmServices();
                                break;
                            default:
                                Console.WriteLine("Invalid option. Please choose 1–3 or 0 to go back.");
                                break;
                        }
                    }
                }
                
                void accountDataViewer()
                {
                    Console.WriteLine("""
                                          === VIEW ACCOUNT DATA ===
                                                      
                                          1) Account Number 
                                          2) Holder Name 
                                          3) Balance 
                                          4) Account Status 
                                          5) Account Type 
                                          0) Back
                                          
                                      """);
                    int option = 1;
                    while (option != 0)
                    {
                        Console.Write("Select: ");
                        option = Convert.ToInt32(Console.ReadLine());

                        switch (option)
                        {
                            case 1:
                                Console.WriteLine("Account Number: " + accountNumber);
                                break;
                            case 2:
                                Console.WriteLine("Holder Name: " + holderName);
                                break;
                            case 3:
                                Console.WriteLine("Balance: " + balance);
                                break;
                            case 4:
                                Console.WriteLine("Account Status: " + (isActive ? "Active" : "Inactive"));
                                break;
                            case 5:
                                Console.WriteLine("Account Type: " + accountType);
                                break;
                            case 0:
                                atmServices();
                                break;
                            default:
                                Console.WriteLine("Invalid option. Please choose 1–5 or 0 to go back.");
                                break;
                        }
                    }   
                }

                void atmPinValidation()
                {
                    Console.WriteLine("""
                                          === AUTHENTICATION ===
                                                      
                                          1) Enter PIN
                                          2) Forgot PIN
                                          0) Back
                                          
                                      """);

                    int option = 1;
                    while (option != 0)
                    {
                        Console.Write("Select: ");
                        option = Convert.ToInt32(Console.ReadLine());

                        switch (option)
                        {
                            case 1:
                                while (maxAttempts > 0)
                                {
                                    Console.Write("Enter PIN: ");
                                    string pin = Console.ReadLine();
                                    if (pin.Length == 4 && pin == correctPin)
                                    {
                                        Console.WriteLine("Access granted. Welcome, " + holderName);
                                    }
                                    else if (pin.Length != 4)
                                    {
                                        Console.WriteLine("Invalid PIN format.");
                                        maxAttempts--;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Incorrect PIN.");
                                        maxAttempts--;
                                    }
                                }
                                if (maxAttempts < 1) { Console.WriteLine("Max Attempts Have been reached."); }
                                break;
                            case 2:
                                Console.WriteLine("Please visit the nearest branch with your National ID.");
                                break;
                            case 0:
                                atmServices();
                                break;
                            default:
                                Console.WriteLine("Invalid option. Please choose 1–2 or 0 to go back.");
                                break;
                        }
                    }
                }

                void atmReceiptPrinter()
                {
                    Console.WriteLine("""
                                          === PRINT RECEIPT ===
                                                      
                                          1) Short Receipt
                                          2) Detailed Receipt
                                          3) Balance Only
                                          0) Back
                                          
                                      """);
                    int option = 1;
                    while (option != 0)
                    {
                        Console.Write("Select: ");
                        option = Convert.ToInt32(Console.ReadLine());
                        switch (option)
                        {
                            case 1:
                                string accountNumberString = accountNumber.ToString();
                                string maskedAccountNumber = (new string('*', accountNumberString.Length - (int) (accountNumberString.Length)/2)) + accountNumberString.Substring(accountNumberString.Length - (int) (accountNumberString.Length)/2);
                                Console.WriteLine("Account: " + maskedAccountNumber);
                                Console.WriteLine("Holder: " + holderName);
                                Console.WriteLine("Balance: " + Math.Round(balance, 3) + " OMR");
                                break;
                            case 2:
                                Console.WriteLine
                                ($"""

                                    --- Account Profile ---
                                    Account Number                       : {accountNumber}
                                    Holder Name                          : {holderName}
                                    Balance                              : {Math.Round(balance, 3)}  OMR
                                    Account Active                       : {isActive}
                                    Account Type                         : {accountType}

                                    --- Customer Profile ---
                                    Employed                             : {isEmployed}
                                    Monthly Salary                       : {salary}
                                    Credit Score                         : {creditScore}
                                    Age                                  : {age}

                                    --- Transaction Data ---
                                    Last Deposit Amount                 : {deposit}
                                    Last Withdrawal                     : {withdrawl}
                                    Annual Interest Rate                : {annualRate}
                                    Avg Monthly Balance                 : {avgBalance}

                                 """);
                                break;
                            case 3:
                                Console.WriteLine("Balace: " + Math.Round(balance, 3) + " OMR");
                                break;
                            case 0:
                                atmServices();
                                break;
                            default:
                                Console.WriteLine("Invalid option. Please choose 1–3 or 0 to go back.");
                                break;
                        }
                    }
                }
            }

            void accountManagment()
            {
                Console.WriteLine("""

                        === Account Management ===

                        1) Transaction Calculator
                        2) Account Type Information
                        3) Loan Eligibility Checker
                        0) Return to Main Menu

                    """);

                int serviceOption = 1;

                while (serviceOption != 0)
                {
                    Console.Write("Select: ");
                    serviceOption = Convert.ToInt32(Console.ReadLine());

                    switch (serviceOption)
                    {
                        case 1:
                            transactionCalculator();
                            break;
                        case 2:
                            accountTypeInformation();
                            break;
                        case 3:
                            loanEligibilityChecker();
                            break;
                        case 0:
                            mainMenu();
                            break;
                        default:
                            Console.WriteLine("Invalid option. Please choose 1–3 or 0 to retrun to main menu.");
                            break;
                    }
                }

                void transactionCalculator()
                {
                    Console.WriteLine($"""
                                          === TRANSACTION CALCULATOR ===

                                           Using balance = {balance} OMR  |  deposit = {deposit} OMR  |  rate = {annualRate * 100} %           
                                         
                                          1) Balance After Deposit
                                          2) Balance After Withdrawal
                                          3) Annual Interest Earned
                                          4) Net Balance Change
                                          0) Back
                                          
                                      """);
                    int option = 1;
                    while (option != 0)
                    {
                        Console.Write("Select: ");
                        option = Convert.ToInt32(Console.ReadLine());
                        switch (option)
                        {
                            case 1:
                                Console.WriteLine("Balance after deposit: " + Math.Round(balance + deposit) + " OMR");
                                break;
                            case 2:
                                Console.WriteLine("Balance after withdrawl: " + Math.Round(balance - withdrawl) + " OMR");
                                break;
                            case 3:
                                Console.WriteLine("Annual Rate: " + annualRate * 100 + " %");
                                Console.WriteLine("Annual Interest Earned: " + Math.Round(balance * annualRate) + " OMR");
                                break;
                            case 4:
                                Console.Write("Net: " + (deposit - withdrawl) + " OMR => ");
                                Console.WriteLine((deposit - withdrawl) > 0? "Surplus" : "Deficit");
                                break;
                            case 0:
                                accountManagment();
                                break;
                            default:
                                Console.WriteLine("Invalid option. Please choose 1–4 or 0 to go back.");
                                break;
                        }
                    }
                }

                void accountTypeInformation()
                {

                }

                void loanEligibilityChecker()
                {
                    string Eligibility = "Not eligible.";

                    Console.WriteLine($"""
                                          === LOAN ELIGIBILITY ===

                                           Holder: {holderName} | Salary: {salary} OMR | Score: {creditScore} | Age: {age}          
                                         
                                          1) Personal Loan
                                          2) Car Loan
                                          3) Home Loan
                                          0) Back
                                          
                                      """);
                    int option = 1;
                    while (option != 0)
                    {
                        Console.Write("Select: ");
                        option = Convert.ToInt32(Console.ReadLine());
                        switch (option)
                        {
                            case 1:
                                if (isEmployed && salary >= 400 && creditScore > 650) { Console.WriteLine("Eligible for Personal Loan."); }
                                else { Console.WriteLine("Not eligible for Personal Loan."); }
                                break;
                            case 2:
                                if (isEmployed && salary >= 600 && age >= 21) { Console.WriteLine("Eligible for Car Loan."); }
                                else { Console.WriteLine("Not eligible for Car Loan."); } 
                                break;
                            case 3:
                                if (isEmployed && salary >= 1000 && creditScore > 700 && age >= 25) { Console.WriteLine("Eligible for Home Loan."); }
                                else { Console.WriteLine("Npt eligible for Home Loan."); } 
                                break;
                            case 0:
                                accountManagment();
                                break;
                            default:
                                Console.WriteLine("Invalid option. Please choose 1–3 or 0 to go back.");
                                break;
                        }
                    }
                    Console.WriteLine(Eligibility);
                }
            }
        }
    }
}
