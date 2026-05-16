namespace ClinicManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //System Storage: all variable declarations

            // Capacity constants
            const int MAX_PATIENTS = 3;
            const int MAX_DOCTORS = 2;
            const int MAX_APPOINTMENTS = 3;

            // Patient slots
            string p1Name = ""; int p1Age = 0; string p1Phone = ""; bool p1Active = false;
            string p2Name = ""; int p2Age = 0; string p2Phone = ""; bool p2Active = false;
            string p3Name = ""; int p3Age = 0; string p3Phone = ""; bool p3Active = false;

            int patientCount = 0;

            // Doctor slots
            string d1Name = ""; string d1Spec = ""; double d1Fee = 0; bool d1Active = false;
            string d2Name = ""; string d2Spec = ""; double d2Fee = 0; bool d2Active = false;

            int doctorCount = 0;

            // Appointment slots
            string a1Patient = ""; string a1Doctor = ""; string a1Date = ""; string a1Status = ""; bool a1Active = false;
            string a2Patient = ""; string a2Doctor = ""; string a2Date = ""; string a2Status = ""; bool a2Active = false;
            string a3Patient = ""; string a3Doctor = ""; string a3Date = ""; string a3Status = ""; bool a3Active = false;

            int appointmentCount = 0;


            //Main Menu: the outer while loop + switch-case
            int option = -1;
            Console.Clear();

            while (option != 0)
            {
                Console.WriteLine("""

                        ╔══════════════════════════════════════╗
                        ║ CLINIC MANAGEMENT SYSTEM             ║
                        ╠══════════════════════════════════════╣
                        ║ 1. Patient Management                ║
                        ║ 2. Doctor Management                 ║
                        ║ 3. Appointment Management            ║
                        ║ 0. Exit                              ║
                        ╚══════════════════════════════════════╝

                    """);

                Console.Write("Enter your choice: ");
                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    //Sub - Menus: one while loop per entity(inside the main menu switch-case case)
                    //Operations: the if-else logic for each CRUD action
                    case 1:
                        int patientOption = -1;
                        Console.Clear();

                        while (patientOption != 0)
                        {
                            Console.WriteLine("""

                                ╔══════════════════════════════════════╗
                                ║ PATIENT MANAGEMENT                   ║
                                ╠══════════════════════════════════════╣
                                ║ 1. Add New Patient                   ║
                                ║ 2. Display All Patients              ║
                                ║ 3. Update Patient Phone              ║
                                ║ 4. Delete Patient                    ║
                                ║ 0. Back to Main Menu                 ║
                                ╚══════════════════════════════════════╝

                            """);

                            Console.Write("Enter your choice: ");
                            patientOption = Convert.ToInt32(Console.ReadLine());

                            switch (patientOption)
                            {
                                case 1:
                                    if (patientCount == MAX_PATIENTS)
                                    {
                                        Console.WriteLine("Clinic is full. Cannot add more patients.");
                                    } else
                                    {
                                        string name;
                                        Console.Write("Enter name: "); name = Console.ReadLine();
                                        if (name == "") { Console.WriteLine("Invalid Name"); break; }
                                        int age;
                                        Console.Write("Enter Age: "); age = int.Parse(Console.ReadLine());
                                        if (age < 0 || age > 120) { Console.WriteLine("Invalid Age"); break; }
                                        string phone;
                                        Console.Write("Enter Phone Number: "); phone = Console.ReadLine();
                                        if (phone == "") { Console.WriteLine("Invalid Phone Number"); break; }

                                        if (!p1Active)
                                        {
                                            p1Name = name; p1Age = age; p1Phone = phone; p1Active = true;
                                        }
                                        else if (!p2Active)
                                        {
                                            p2Name = name; p2Age = age; p2Phone = phone; p2Active = true;
                                        }
                                        else if (!p3Active)
                                        {
                                            p3Name = name; p3Age = age; p3Phone = phone; p3Active = true;
                                        }

                                        patientCount++;
                                    }
                                    break;
                                case 2:
                                    int counter = 0;
                                    if (patientCount == 0) { Console.WriteLine("No patients registered."); }
                                    if (p1Active) { counter++; Console.WriteLine($"Patient #{counter} Name: {p1Name}, Age: {p1Age}, Phone: {p1Phone}"); }
                                    if (p2Active) { counter++; Console.WriteLine($"Patient #{counter} Name: {p2Name}, Age: {p2Age}, Phone: {p2Phone}"); }
                                    if (p3Active) { counter++; Console.WriteLine($"Patient #{counter} Name: {p3Name}, Age: {p3Age}, Phone: {p3Phone}"); }
                                    break;
                                case 3:
                                    string targetPatient;
                                    Console.Write("Enter Target Patient Name: "); targetPatient = Console.ReadLine();
                                    if (p1Active && p1Name == targetPatient) { Console.Write("Enter new phone: "); p1Phone = Console.ReadLine(); Console.Write($"{targetPatient} phone updated."); }
                                    else if (p2Active && p2Name == targetPatient) { Console.Write("Enter new phone: "); p2Phone = Console.ReadLine(); Console.Write($"{targetPatient} phone updated."); }
                                    else if (p3Active && p3Name == targetPatient) { Console.Write("Enter new phone: "); p3Phone = Console.ReadLine(); Console.Write($"{targetPatient} phone updated."); }
                                    else { Console.WriteLine("This Patient Does not exist "); }
                                    break;
                                case 4:
                                    string targetDeletePatient;
                                    Console.Write("Enter Target Patient Name: "); targetDeletePatient = Console.ReadLine();
                                    if (p1Active && p1Name == targetDeletePatient) { p1Name = ""; p1Age = 0; p1Phone = ""; p1Active = false; patientCount--; Console.Write($"{targetDeletePatient} have been deleted."); }
                                    else if (p2Active && p2Name == targetDeletePatient) { p2Name = ""; p2Age = 0; p2Phone = ""; p2Active = false; patientCount--;Console.Write($"{targetDeletePatient} have been deleted."); }
                                    else if (p3Active && p3Name == targetDeletePatient) { p2Name = ""; p2Age = 0; p2Phone = ""; p2Active = false; patientCount--;Console.Write($"{targetDeletePatient} have been deleted."); }
                                    else { Console.WriteLine("This Patient Does not exist "); }
                                    break;
                                case 0:
                                    patientOption = 0;
                                    break;
                                default:
                                    Console.WriteLine("do NOT exit the program");
                                    break;
                            }
                        }

                        break;
                    case 2:
                        int docotrOption = -1;
                        Console.Clear();

                        while (docotrOption != 0)
                        {
                            Console.WriteLine("""

                                ╔══════════════════════════════════════╗
                                ║ DOCTOR MANAGEMENT                    ║
                                ╠══════════════════════════════════════╣
                                ║ 1. Add New Doctor                    ║
                                ║ 2. Display All Doctors               ║
                                ║ 3. Update Consultation Fee           ║
                                ║ 4. Delete Doctor                     ║
                                ║ 0. Back to Main Menu                 ║
                                ╚══════════════════════════════════════╝

                            """);

                            Console.Write("Enter your choice: ");
                            docotrOption = Convert.ToInt32(Console.ReadLine());

                            switch (docotrOption)
                            {
                                case 1:
                                    if (doctorCount == MAX_DOCTORS)
                                    {
                                        Console.WriteLine("No available doctor slots.");
                                    } else
                                    {
                                        string docName;
                                        Console.Write("Enter doctor name: "); docName = Console.ReadLine();
                                        if (docName == "") { Console.WriteLine("Invalid Name"); break; }
                                        string specialization;
                                        Console.Write("Enter doctor specialization: "); specialization = Console.ReadLine();
                                        if (specialization == "") { Console.WriteLine("Invalid specialization name"); break; }
                                        double fee;
                                        Console.Write("Enter doctor fee: "); fee = Convert.ToDouble(Console.ReadLine());
                                        if (fee < 0) { Console.WriteLine("Invalid fee value"); break; }
                                        
                                        if (!d1Active)
                                        {
                                            d1Name = docName; d1Spec = specialization; d1Fee = fee; d1Active = true;
                                        }
                                        else if (!d2Active)
                                        {
                                            d2Name = docName; d2Spec = specialization; d2Fee = fee; d2Active = true;
                                        }

                                        doctorCount++;
                                    }
                                    break;
                                case 2:
                                    int counter = 0;
                                    if (counter == 0) { Console.WriteLine("No doctors registered."); }
                                    if (d1Active) { counter++; Console.WriteLine($"Doctor #{counter} Name: {d1Name}, Specialization: {d1Spec}, Fee: {d1Fee}"); }
                                    if (d2Active) { counter++; Console.WriteLine($"Doctor #{counter} Name: {d2Name}, Specialization: {d2Spec}, Fee: {d2Fee}"); }
                                    break;
                                case 3:
                                    string targetDoctor;
                                    Console.Write("Enter Target Doctor Name: "); targetDoctor = Console.ReadLine();
                                    if (d1Active && d1Name == targetDoctor) { Console.Write("Enter new fee: "); d1Fee = double.Parse(Console.ReadLine()); Console.Write($"{targetDoctor} fee updated."); }
                                    else if (d2Active && d2Name == targetDoctor) { Console.Write("Enter new fee: "); d2Fee = double.Parse(Console.ReadLine()); Console.Write($"{targetDoctor} fee updated."); }
                                    else { Console.WriteLine("This Doctor Does not exist "); }
                                    break;
                                case 4:
                                    string targetDeleteDoctor;
                                    Console.Write("Enter Target Doctor Name: "); targetDeleteDoctor = Console.ReadLine();
                                    if (d1Active && d1Name == targetDeleteDoctor) { d1Name = ""; d1Fee = 0; d1Spec = ""; d1Active = false; doctorCount--; Console.Write($"{targetDeleteDoctor} have been deleted."); }
                                    if (d2Active && d2Name == targetDeleteDoctor) { d2Name = ""; d2Fee = 0; d2Spec = ""; d2Active = false; doctorCount--; Console.Write($"{targetDeleteDoctor} have been deleted."); }
                                    else { Console.WriteLine("This Doctor Does not exist "); }
                                    break;
                                case 0:
                                    docotrOption = 0;
                                    break;
                                default:
                                    Console.WriteLine("do NOT exit the program");
                                    break;
                            }
                        }
                        break;
                    case 3:
                        int appointmentOption = -1;
                        Console.Clear();

                        while (appointmentOption != 0)
                        {
                            Console.WriteLine("""

                                ╔══════════════════════════════════════╗
                                ║ APPOINTMENT MANAGEMENT               ║
                                ╠══════════════════════════════════════╣
                                ║ 1. Book New Appointment              ║
                                ║ 2. Display All Appointments          ║
                                ║ 3. Update Appointment Status         ║
                                ║ 4. Cancel Appointment                ║
                                ║ 0. Back to Main Menu                 ║
                                ╚══════════════════════════════════════╝

                            """);

                            Console.Write("Enter your choice: ");
                            appointmentOption = Convert.ToInt32(Console.ReadLine());

                            switch (appointmentOption)
                            {
                                case 0:
                                    appointmentOption = 0;
                                    break;
                                default:
                                    Console.WriteLine("do NOT exit the program");
                                    break;
                            }
                        }
                        break;
                    case 0:
                        option = 0;
                        break;
                    default:
                        Console.WriteLine("do NOT exit the program");
                        break;
                }
            }
        }
    }
}
