using System;
using System.Collections.Generic;
using System.Text;
using P128H.Interface;

namespace P128H.Models
{
    class User : Iaccount
    #region Task1
    //{

    //public string Fullname;
    //public string Email;
    //private string _Password;
    //public string Password;

    //public User(string v1, string v2)
    //{
    //    V1 = v1;
    //    V2 = v2;
    //}

    //public string V1 { get; }
    //public string V2 { get; }
    #endregion
    #region Task sehf
    //public string Password
    //{
    //    get => _Password;


    //    set 
    //    {
    //        bool check22 = true;
    //        while (true)
    //        {
    //            bool check = false;
    //            bool check2 = false;
    //            bool check3 = false;
    //            if (value.Length >=8)
    //            {
    //                foreach (char item in value)
    //                {
    //                    if (char.IsUpper(item))
    //                    {
    //                        check = true;
    //                    }
    //                    else if (char.IsLower(item))
    //                    {
    //                        check2 = true;
    //                    }
    //                    else if (char.IsDigit(item))
    //                    {
    //                        check3 = true;
    //                    }
    //                }
    //                if (check2 == true && check && check3)
    //                {
    //                    _Password = value;
    //                    check22 = false;
    //                    break;
    //                }
    //                else
    //                {
    //                    Console.WriteLine("Sifreni Duzgun Daxil Et");
    //                    value = Console.ReadLine();
    //                }
    //            }
    //        }
    //    }
    //}


    //public User(string password, string v)
    //{
    //    Password = _Password;
    //}

    //public void ShowInfo()
    //{
    //    Console.WriteLine(Fullname+Email);
    //}
    #endregion
    #region Task1
    //    public void ShowInfo()
    //        {
    //            Console.WriteLine(Fullname+Email);
    //        }
    //        public bool PasswordChecker(string a, int min)
    //        {
    //            bool check1 = false;
    //            bool check2 = false;
    //            bool check3 = false;
    //            bool check4 = false;
    //            char check;
    //            if (!(a.Length >= min))
    //            {
    //                return false;
    //            }
    //            for (int i = 0; i < a.Length; i++)
    //            {
    //                check = a[i];
    //                if (char.IsDigit(check))
    //                {
    //                    check1 = true;
    //                }
    //                else if (char.IsUpper(check))
    //                {
    //                    check2 = true;
    //                }
    //                else if (char.IsLetterOrDigit(check))
    //                {
    //                    check3 = true;
    //                }
    //            }
    //            return false;
    //        }

    //        public bool PasswordChecker(string a)
    //        {

    //            int min = 1;
    //            bool check1 = false;
    //            bool check2 = false;
    //            bool check3 = false;
    //            bool check4 = false;
    //            char check;
    //            if (!(a.Length >= min))
    //            {
    //                return false;
    //            }
    //            for (int i = 0; i < a.Length; i++)
    //            {
    //                check = a[i];
    //                if (char.IsDigit(check))
    //                {
    //                    check1 = true;
    //                }
    //                else if (char.IsUpper(check))
    //                {
    //                    check2 = true;
    //                }
    //                else if (char.IsLetterOrDigit(check))
    //                {
    //                    check3 = true;
    //                }
    //            }
    //            return false; 
    //        }
//}
    #endregion;
}

