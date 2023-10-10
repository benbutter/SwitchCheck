using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCheck
{
    public class Control
    {
        public List<string> strings = new List<string>();
        public int ACount = 0;
        public int BCount = 0;  
        public int CCount = 0;
        public int DCount = 0;
        public int ECount = 0;
        public int FCount = 0;
        public int GCount = 0;
        public int HCount = 0;
        public int ICount = 0;
        public int JCount = 0;

        public int numberInArrayToCheck = 10000000;//0;
        public int scenarioNumber = 10;
        public void Execute()
        {
            SetupStrings();
            CheckIfElse();
            CheckSwitch();
        }

        private void SetupStrings()
        {
            //  string[] stringsArray = {"A", "B", "C"};
            string[] stringsArray = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
            Random random = new Random();
            for (int i = 0; i < numberInArrayToCheck; i++) 
            {
                int index = random.Next(scenarioNumber);
                strings.Add(stringsArray[index]);
            }
        }

        private void CheckIfElse()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            foreach (string s in strings)
            {
                if (s == "A")
                {
                    ACount++;
                }
                else if (s == "B")
                {
                    BCount++;
                }
                else if (s == "C")
                {
                    CCount++;
                }
                else if (s == "D")
                {
                    DCount++;
                }
                else if (s == "E")
                {
                    ECount++;
                }
                else if (s == "F")
                {
                    FCount++;
                }
                else if (s == "G")
                {
                    GCount++;
                }
                else if (s == "H")
                {
                    HCount++;
                }
                else if (s == "I")
                {
                    ICount++;
                }
                else if (s == "J")
                {
                    JCount++;
                }
            }

            stopwatch.Stop();
            Console.WriteLine($"with {numberInArrayToCheck} in array. IfElse took {stopwatch.Elapsed.ToString()} for {scenarioNumber} scenarios");
        }

        private void CheckSwitch()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            foreach (string s in strings)
            {
                switch (s)
                {
                    case "A":
                        ACount++;
                        break;

                    case "B":
                        BCount++;
                        break;

                    case "C":
                        CCount++;
                        break;

                    case "D":
                        DCount++;
                        break;

                    case "E":
                        ECount++;
                        break;

                    case "F":
                        FCount++;
                        break;

                   case "H":
                        HCount++;
                        break;

                   case "I":
                        ICount++;
                        break;

                    case "J":
                        JCount++;
                        break;


                }
               
            }

            stopwatch.Stop();
            Console.WriteLine($"with {numberInArrayToCheck} in array. Switch took {stopwatch.Elapsed.ToString()} for {scenarioNumber} scenarios" );
        }
    }
}
