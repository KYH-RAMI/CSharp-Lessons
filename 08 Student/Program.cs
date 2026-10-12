namespace Student
{

    public class Student
    {
        public string Namn
        {
            get;
            set;
        }
        public bool AktivStatus
        {
            get;
            set;
        }

        public class Kurs
        {
            public string Kursnamn
            {
                get;
                set;
            }
            public void RegistreraStudent(Student student)
            {
                if (student.AktivStatus)
                {
                    Console.WriteLine($"Registreringen lyckades för {student.Namn}");
                }
                else
                {
                    Console.WriteLine($"Registreringen misslyckades för {student.Namn}");
                }
            }


        }

        internal class Program
        {
            static void Main(string[] args)
            {
                #region header
                Console.WriteLine("07 Student");
                Console.Title = "07 Student";
                Console.WriteLine("==========================");
                Console.WriteLine();
                #endregion

                Kurs kurs = new Kurs();
                kurs.Kursnamn = "C#";
                Student student = new Student();
                student.Namn = "Kalle";
                student.AktivStatus = true;
                kurs.RegistreraStudent(student);
                student.Namn = "BoBo";
                student.AktivStatus = false;
                kurs.RegistreraStudent(student);

                #region footer
                Console.WriteLine("\n\n==========================");
                Console.WriteLine("\nTryck på en tangent för att avsluta...");
                Console.ReadKey();
                #endregion
            }

        }
    }
}