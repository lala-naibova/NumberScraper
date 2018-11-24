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
  
        const string validSymbols = "1234567890() -";

        public List<string> ListTheNumbers(string path)
        {            
            using (StreamReader sreader = new StreamReader(path))            
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

        static int GetDigitCount(string str) => str.Count(c => char.IsDigit(c));


        static int GetFirstDigitIndex(string str, int startFrom = 0)
        {
            int firstIndex = -1;

            for (int i = startFrom; i < str.Length; i++)
            {
                char c = str[i];

                if (char.IsDigit(c))
                {
                    firstIndex = i;
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
            IEnumerable<char> chars = str.Where(c => char.IsDigit(c));

            //string str1 = new string(chars.ToArray());

            string result = String.Concat(str.Where(c => char.IsDigit(c)));
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
                str = "994" + str.Substring(1);
            }
            else if (str.Length == 7)
            {
                str = "99412" + str;
            }
            return str;
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

       
    }
}
