using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ArrayOfObjects = new string[] { "1", "3", "sex" };
            ArrayOfObjects = func1(ArrayOfObjects);
            Console.WriteLine(ArrayOfObjects);

            string test = "Abut-1-tUba";
            func2(test);

            int[] ArrayOfObjects2 = new int[] { 1, 2, 5, 3, 7, 0, 7, 3, 5, 2, 1 };
            int[] ArrayOfObjects3 = new int[] { 7, 3, 1, 2, 5, 0, 5, 2, 1, 3, 7 };

            func3(ArrayOfObjects2, ArrayOfObjects3);

            List<int> testlist = new List<int>();
            testlist.Add(1);
            testlist.Add(3);
            testlist.Add(4);

            func4(testlist);

            findPrimes();
        }

        private static string func4(List<int> inputList)
        {
            List<int> powersList = new List<int>();
            var returnString = "";

            for (int i = 0; i < inputList.Count; i++)
            {
                powersList = returnPowersOfTwo(inputList.ElementAt(i), powersList);
            }
            
            for(int j = 0; j < powersList.Count; j++)
            {
                if (j + 1 != powersList.Count)
                    returnString += powersList[j] + ",";
                else
                    returnString += powersList[j];
            }

            return returnString;
        }

        private static void findPrimes()
        {
            int num, i, ctr, testcasenumber;
            List<int> endrangelist = new List<int>();
            List<int> startrangelist = new List<int>();

            Console.Write("\n\n");
            Console.Write("How many test cases will there be:\n");
            testcasenumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\n");

            for (int j = 0; j < testcasenumber; j++)
            {
                Console.Write("Input starting number of range: ");
                startrangelist.Add(Convert.ToInt32(Console.ReadLine()));
                Console.Write("Input ending number of range : ");
                endrangelist.Add(Convert.ToInt32(Console.ReadLine()));
            }

            for (int x = 0; x < startrangelist.Count; x++)
            {

                int primes = 0;
                for (num = startrangelist.ElementAt(x); num <= endrangelist.ElementAt(x); num++)
                {
                    ctr = 0;

                    for (i = 2; i <= num / 2; i++)
                    {
                        if (num % i == 0)
                        {
                            ctr++;
                            break;
                        }
                    }

                    if (ctr == 0 && num != 1)
                        primes++;
                }

                Console.Write(primes + "\n");
            }
        }

    private static List<int> returnPowersOfTwo(int inputList, List<int> powersList)
        {

            if (inputList != 0 && !powersList.Contains(1))
                powersList.Add(1);

            int num = inputList;
            int j = 1;

            while(num % 2 == 0)
            {
                num = num / 2;
                if(!powersList.Contains(j*2))
                    powersList.Add(j * 2);
                j++;
            }
                return powersList;
        }

        private static string func3(int[] array1, int[] array2)
        {
            if (array1.Length != array2.Length)
                return "NO";

            int mul1 = 1;
            int mul2 = 1;
            int sum1 = 0;
            int sum2 = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                mul1 *= array1[i];
                mul2 *= array2[i];

                sum1 += array1[i];
                sum2 += array2[i];
            }

            if (mul1 == mul2 && sum1 == sum2)
                return "YES";
            else
                return "NO";

        }

        private static string func2(string stringToCheck)
        {
            stringToCheck = filterForBadCharacters(stringToCheck.ToLower());
            string temp = new string (func1(stringToCheck.ToCharArray()));
            if (temp.ToString().Equals(stringToCheck))
                return "YES";
            else
                return "NO";
        }

        private static string filterForBadCharacters(string unfilteredString)
        {

            unfilteredString = Regex.Replace(unfilteredString, "[^a-zA-Z]", "");
            return unfilteredString;

        }

        private static T[] func1<T>(T[] balance)
        {
            Array.Reverse(balance);
            return balance;
        }
    }
}
