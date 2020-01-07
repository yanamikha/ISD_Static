//Создать собственные реализации методов Substring(int, int), IndexOf(string), Replace(string, string)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CustomStringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = @"It's my life
It's now or never
I ain't gonna live forever...";
            Console.WriteLine("Your string is:\n" + str);
            Console.WriteLine(str.Substring_(2, 5));
            Console.WriteLine(str.IndexOf_("l"));
            Console.WriteLine(str.Replace_(" n", "_*"));

            Console.ReadKey();

        }
    }
    static class StringExtension
    {
        public static string Substring_(this string str, int startIndex, int length)
        {
            string result = "";
            for (int i = startIndex; i < length ; i++)
                result += str[i];
            return result;
        }

        public static int IndexOf_(this string str, string subStr)
        {

            for (int i = 0; i < subStr.Length; i++)
                for (int k = 0; k < str.Length; k++)
                    if (str[k] == subStr[i])
                        if (str.Substring_(k, k + subStr.Length) == subStr)
                            return k;
            return -1;
        }

        public static string Replace_(this string str, string oldStr, string newStr)
        {
            string res = str;
            while (res.IndexOf_(oldStr) != -1)
            {
                res = Substring_(res, 0, res.IndexOf_(oldStr)) + newStr + Substring_(res, res.IndexOf_(oldStr) + oldStr.Length, res.Length);
            }
            return res;
        }
    }
}
