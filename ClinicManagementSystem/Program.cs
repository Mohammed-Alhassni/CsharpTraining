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
