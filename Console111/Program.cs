using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console111
{
    internal class Program
    {
        static void Main()
        {
            string versionNumberOne = "111.0013.2000.16";
            string versionNumberTwo = "111.009.2000.16";
            var arrayV1S = new string[NumberOfNumbersInTheVersion(versionNumberOne)];
            var arrayV2S = new string[NumberOfNumbersInTheVersion(versionNumberTwo)];
            arrayV1S = versionNumberOne.Split('.');
            arrayV2S = versionNumberTwo.Split('.');
            var arrayV1I = new int[NumberOfNumbersInTheVersion(versionNumberOne)];
            var arrayV2I = new int[NumberOfNumbersInTheVersion(versionNumberTwo)];
            for (int i = 0; i < arrayV1I.Length; i++)
            {
                arrayV1I[i] = int.Parse(arrayV1S[i]);
                Console.WriteLine(arrayV1I[i]);
            }
            for (int i = 0; i < arrayV2S.Length; i++)
            {
                arrayV2I[i] = int.Parse(arrayV2S[i]);
                Console.WriteLine(arrayV2I[i]);
            }
            //
            if (arrayV1I.Length == arrayV2I.Length)
            {
                for (int i = 0; i < arrayV1I.Length; i++)
                {
                    if (arrayV1I[i] < arrayV2I[i])
                    {
                        Console.WriteLine("Первая версия меньше второй");
                        break;
                    }
                    if (arrayV1I[i] > arrayV2I[i])
                    {
                        Console.WriteLine("Первая версия больше второй");
                        break;
                    }


                }
            }
            else
            {
                if (arrayV1I.Length > arrayV2I.Length)
                {
                    for (int i = 0; i < arrayV2I.Length; i++)
                    {
                        if (arrayV1I[i] == arrayV2I[i])
                        {
                            Console.WriteLine("Первая версия больше второй");
                            break;
                        }
                        if (arrayV1I[i] != arrayV2I[i])
                        {
                            Console.WriteLine("Первая версия меньше второй");
                            break;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < arrayV1I.Length; i++)
                    {
                        if (arrayV1I[i] == arrayV2I[i])
                        {
                            Console.WriteLine("Первая версия меньше второй");
                            break;
                        }
                        if (arrayV1I[i] != arrayV2I[i])
                        {
                            Console.WriteLine("Первая версия больше второй");
                            break;
                        }
                    }

                }
            }
            
        }
        public static int NumberOfNumbersInTheVersion(string versionNumber)
        {
            var point = ".";
            int count = 0;
            int plusOneMoreElement = 1;
            foreach (char c in versionNumber)
            {
                if (c == Convert.ToChar(point))
                    ++count;
            }
            return count + plusOneMoreElement;
        }
    }
}
