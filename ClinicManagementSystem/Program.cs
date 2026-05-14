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

            while (option != 0)
            {
                Console.Clear();
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
                    case 0:
                        break;
                    default:
                        Console.WriteLine("do NOT exit the program");
                        break;
                }
            }
        }
    }
}
