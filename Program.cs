using System;

namespace exercise2
{
    public struct Name
    {
        public string FirstName;
        public string MiddleName;
        public string LastName;

        public override string ToString()
        {
            return $"{LastName} {MiddleName} {FirstName}";
        }
    }

    public struct HomeTown
    {
        public string Commune;
        public string District;
        public string Province;

        public override string ToString()
        {
            return $"{Commune}, {District}, {Province}";
        }
    }

    public struct Score
    {
        public double Maths;
        public double Physics;
        public double Chemistry;

        public double TotalScore()
        {
            return Maths + Physics + Chemistry;
        }
    }

    public class THISINH
    {
        public Name Name;
        public HomeTown HomeTown;
        public string School = "";
        public int Age;
        public string IdNumber = "";
        public Score Score;

        public double TotalScore()
        {
            return Score.TotalScore();
        }

        public void EnterInfo()
        {
            Console.WriteLine("Enter candidate's information:");

            Console.Write("Last name: ");
            Name.LastName = Console.ReadLine() ?? "";       // operator ?? to assign default value as empty string ("") if input is null

            Console.Write("Middle name: ");
            Name.MiddleName = Console.ReadLine() ?? "";

            Console.Write("First name: ");
            Name.FirstName = Console.ReadLine() ?? "";

            Console.Write("Commune: ");
            HomeTown.Commune = Console.ReadLine() ?? "";

            Console.Write("District: ");
            HomeTown.District = Console.ReadLine() ?? "";

            Console.Write("Province: ");
            HomeTown.Province = Console.ReadLine() ?? "";

            Console.Write("School: ");
            School = Console.ReadLine() ?? "";

            Console.Write("Age: ");
            Age = int.Parse(Console.ReadLine() ?? "");

            Console.Write("ID number: ");
            IdNumber = Console.ReadLine() ?? "";

            Console.Write("Maths score: ");
            Score.Maths = double.Parse(Console.ReadLine() ?? "");

            Console.Write("Physics score: ");
            Score.Physics = double.Parse(Console.ReadLine() ?? "");

            Console.Write("Chemistry score: ");
            Score.Chemistry = double.Parse(Console.ReadLine() ?? "");
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"| {Name,-30} | {HomeTown,-35} | {IdNumber,-18} | {Score.Maths,-8} | {Score.Physics,-8} | {Score.Chemistry,-10} | {TotalScore().ToString("0.00"),-11} |");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<THISINH> candidateList = new List<THISINH>();

            Console.Write("Enter number of candidate: ");
            int n = int.Parse(Console.ReadLine());

            // initialize list of candidates
            for (int i=0; i<n; i++)
            {
                THISINH ts = new THISINH();
                ts.EnterInfo();
                candidateList.Add(ts);
                Console.WriteLine();
            }

            // display list of candidates
            TitleDisplay();
            foreach (THISINH ts in candidateList)
            {
                ts.DisplayInfo();
            }
            Console.WriteLine();

            // find and print out candidates who have total score > 15
            Console.WriteLine("List of candidate with total score > 15: ");         
            TitleDisplay();
            List<THISINH> candidateList2 = new List<THISINH>();
            foreach(THISINH ts2 in candidateList)
            {
                if(ts2.TotalScore() > 15)
                {
                    candidateList2.Add(ts2);
                }
            }

            foreach (THISINH ts2 in candidateList2)
            {
                ts2.DisplayInfo();
            }
            
            
            Console.ReadKey();
        }

        static void TitleDisplay()
        {
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"| {"Full Name",-30} | {"Hometown",-35} | {"ID Number",-18} | {"Maths",-8} | {"Physics",-8} | {"Chemistry",-10} | {"Total score",-8} |");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------");
        }
    }
}