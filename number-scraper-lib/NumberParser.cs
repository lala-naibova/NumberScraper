using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberScraperLib
{
    public class NumberParser : INumberParser
    {
        static string mainNumbers = "1234567890";
        static string anotherSymbols = "() -";

        static readonly string validSymbols = string.Concat(mainNumbers, anotherSymbols);

        public List<string> ListTheNumbers(string path)
        {
            StreamReader sreader = null;
            try
            {
                sreader = new StreamReader(path);

            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found.");
                Environment.Exit(0);
            }

            using (sreader)            
            {
                
                List<string> numbers = new List<string>();

                while (!sreader.EndOfStream)
                {
                    string line = sreader.ReadLine();

                    int digitCount = GetDigitCount(line);

                    if (digitCount < 7)
                    {
                        continue;
                    }

                    int firstIndex = GetFirstDigitIndex(line);

                    int lastIndex = GetStopIndex(line, firstIndex);

                    string firstVersion = line.Substring(firstIndex, lastIndex - firstIndex);

                    string lastVersion = RemoveNonDigitChars(firstVersion);

                    if (lastVersion.Length >= 7 && IsValidPhoneNumber(lastVersion))
                    {

                        numbers.Add(SetNumberStyle(lastVersion));
                       
                    }

                }
                return numbers;                        
            }

        }

        static bool IsValidPhoneNumber(string str)
        {
            string[] operatorCodes = new string[] { "055", "055", "077", "012" };
            string[] operatorCodes2 = new string[] { "55", "55", "77" };
            string[] operatorCodes3 = new string[] { "99455", "99455", "99477", "99412" };
            string first3Letters = str.Substring(0, 3);
            string first2Letters = str.Substring(0, 2);
            string first5Letters = str.Substring(0, 5);

            if (operatorCodes.Contains(first3Letters) && str.Length == 10 && (str[3] != '0' || str[3] != '1'))
            {
                return true;
            }
            if (operatorCodes2.Contains(first2Letters) && str.Length == 9 && (str[2] != '0' || str[2] != '1'))
            {
                return true;
            }
            if (operatorCodes3.Contains(first5Letters) && str.Length == 12 && (str[5] != '0' || str[5] != '1'))
            {
                return true;
            }

            return false;
        }

        static int GetDigitCount(string str)
        {

            int count = 0;

            foreach (char c in str)
            {
                if (mainNumbers.Contains(c))
                {
                    count++;
                }
            }


            return count;
        }

        static int GetFirstDigitIndex(string str, int startFrom = 0)
        {
            int firstIndex = -1;

            for (int i = startFrom; i < str.Length; i++)
            {
                char c = str[i];

                if (mainNumbers.Contains(c))
                {
                    firstIndex = str.IndexOf(c);
                    break;
                }
            }

            return firstIndex;
        }

        static int GetStopIndex(string str, int startFrom)
        {
            int lastIndex = str.Length;

            for (int i = startFrom; i < str.Length; i++)
            {
                char c = str[i];
                if (!validSymbols.Contains(c))
                {
                    lastIndex = i;
                    break;
                }
            }

            return lastIndex;

        }

        static string RemoveNonDigitChars(string str)
        {
            string result = string.Empty;

            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];

                if (mainNumbers.Contains(c))
                {
                    result += c;
                }
            }
            return result;
        }

        static string SetNumberStyle(string str)
        {
            if (str.Length == 9)
            {
                str = "994" + str;
            }
            else if (str.Length == 10)
            {
                str = "994" + str.Substring(1, str.Length - 1);
            }
            else if (str.Length == 7)
            {
                str = "99412" + str;
            }
            return str;
        }

        static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        static string GetResultPath(string filePath)
        {
            int indexOfDot = filePath.LastIndexOf('.');
            if (indexOfDot==-1)
            {
                return filePath + "-numbers.txt";
            }
            string pathPart = filePath.Substring(0, indexOfDot);
            string fileName = $"{pathPart}-numbers.txt";
            return fileName;
        }

        static string GetOnlyNumbers(string str)
        {
            int digitCount = GetDigitCount(str);

            int firstIndex = GetFirstDigitIndex(str);

            int lastIndex = GetStopIndex(str, firstIndex);

            string firstVersion = str.Substring(firstIndex, lastIndex - firstIndex);

            return RemoveNonDigitChars(firstVersion);

        }
    }
}
