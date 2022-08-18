using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    class Student
    {
        private string _fullname;
        private string _groupNo;
        private int _age;

        public string FullName
        {
            get
            {
                return _fullname;
            }
            set
            {
                if (CheckFullname(value))
                {
                    _fullname = value;
                }
            }
        }
        public string GroupNo
        {
            get
            {
                return _groupNo;
            }
            set
            {
                if (CheckGroupNo(value))
                {
                    _groupNo = value;
                }
            }
        }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value > 0 && value < 88)
                {
                    _age = value;
                }
            }
        }

        public static bool CheckGroupNo(string str)
        {
            if (str.Length == 4 && Char.IsUpper(str[0]) && Char.IsDigit(str[2]) && Char.IsDigit(str[3]) && str[1] > 48 && str[1] < 58)
            {
                return true;

            }
            return false;
        }

        public static bool CheckFullname(string str)
        {
            int IndexOfSpace = str.IndexOf(' ');

            if (IndexOfSpace == -1 || IndexOfSpace == str.Length)
                return false;

            string Name = str.Substring(0, IndexOfSpace);
            string Surname = str.Substring(IndexOfSpace + 1);
            if (!Char.IsUpper(Name[0]) || !Char.IsUpper(Surname[0]))
                return false;

            for (int i = 1; i < Name.Length; i++)
            {
                if (!Char.IsLower(Name[i]))
                    return false;
            }

            for (int i = 1; i < Surname.Length; i++)
            {
                if (!Char.IsLower(Surname[i]))
                    return false;
            }

            return true;

        }
    }
}
