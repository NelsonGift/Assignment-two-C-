using System;
namespace answers
{
    //Answer to question One of the Exercise
    public delegate void studentDetails();
    
    internal class Program
    {
        public static void getStudentName()
        {
            Console.WriteLine("StudentName:");
        }
        public static void getStudentID()
        {
            Console.WriteLine("StudentID:");
        }
        static void Main(string[] args)
        {
           //Invoking the student details delegates 
            studentDetails name,id;
            name = getStudentName;
            id = getStudentID;
            name();
            Console.WriteLine("James");
            id();
            Console.WriteLine("012");
            
            //invoking the property for student Address
            Program s = new Program();
            s.StudentAddress = "Kampala";
            Console.WriteLine("\nStudent Address is:" +s.StudentAddress);

            // invoking Student Details from Dictionary
            s.storeDick();
            

        }
        //Answers to question two for properties
        private string address;
        public string StudentAddress
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }
        //Number three for Dictionaries
        private static string Name;
        private static int idd;
        private string studentAddress;

        public void storeDick()
        {


            Dictionary<int, string> dc = new Dictionary<int, string>();
            dc.Add(1, idd.ToString());
            dc.Add(2, Name);
            dc.Add(3, studentAddress);


            Console.WriteLine("\n");
            foreach (KeyValuePair<int, string> i in dc)
            {

                Console.WriteLine(" " + i.Value);
            }
        }

    }
    
}