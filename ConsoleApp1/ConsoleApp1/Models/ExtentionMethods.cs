using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
   static class ExtentionMethods
    {
        public static bool IsOdd(this int num)
        {
            if (num % 2 == 1)
            {
                return true;
            }
            return false;
        }
        public static bool IsEven(this int num)
        {
            if (num%2==0)
            {
                return true;
            }
            return false;
        }
        public static bool IsContainsDigit(this string str)
        {
            foreach (char item in str)
            {
                if (item > 47 && item < 58)
                {
                    return true;
                }
                
            }
            return false;
        }
        public static string ToCapitalize( this string str)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(char.ToUpper(str[0]));
            sb.Append(str.Substring(1).ToLower());
            return sb.ToString();
        }
        public static int[] GetValueIndexes( this string str, char ch)
        {
            int[] arr = new int[0];
            for (int i = 0; i <str.Length; i++)
            {
                if (str[i]==ch)
                {
                    Array.Resize<int>(ref arr, arr.Length + 1);
                    arr[arr.Length - 1] = i;
                }
            }
            return arr;
        }
            


    }
}
