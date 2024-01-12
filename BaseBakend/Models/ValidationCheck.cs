using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBakend.Models
{

    public partial class Person
    {
        public static string IsValidInput(string name)
        {


            do
            {

                bool isXValid = true;
                if (isXValid)
                {
                    for (int i = 0; i < name.Length; i++)
                    {
                        if (!char.IsLetter(name[i]))
                        {
                            isXValid = false;
                            break;
                        }
                    }
                }

                if (!isXValid)
                {
                    throw new Exception(message: "Invalid input please try again:");

                }
                if (isXValid)
                {

                    break;
                }


            }
            while (true);
            return name;
        }

        public static string IsValidNumber(string Number)
        {
            do
            {
                bool isXValid = true;
                if (isXValid)
                {
                    for (int i = 0; i < Number.Length; i++)
                    {
                        if (!char.IsDigit(Number[i]))
                        {
                            isXValid = false;
                            break;
                        }
                    }
                }

                if (!isXValid)
                {
                    throw new Exception(message: "Invalid number please try again:");

                }
                if (isXValid)
                {

                    break;
                }


            }
            while (true);
            return Number;
        }

        public static string IsValidPhoneNumber(string phoneNumber)

        {

            do
            {

                bool isPhoneValid = phoneNumber.Length == 10 || phoneNumber.Length == 11 || phoneNumber.Length == 13;
                if (isPhoneValid)
                {

                    for (int i = 0; i < phoneNumber.Length; i++)
                    {
                        if (!char.IsDigit(phoneNumber[i]))
                        {
                            if (phoneNumber[0] == '0' && phoneNumber.Length == 10)
                            {
                                if (phoneNumber[0] == '+' && phoneNumber.Length == 10)
                                {
                                    if (!(phoneNumber[i] == '+' && i == 0))
                                    {

                                        isPhoneValid = false;
                                        break;
                                    }

                                }
                            }
                        }
                    }
                }
                if (!isPhoneValid)
                {
                    throw new Exception(message: "Invalid phoneNumber please try again: ");


                }
                if (isPhoneValid)

                {
                    break;

                }


            } while (true);
            return phoneNumber;
        }
        public static string ReplacePhone(string phoneNumber)
        {
            if (phoneNumber.Substring(0, 3) == "+98")
            {
                phoneNumber = phoneNumber.Replace("+98", "0");
            }
            if (phoneNumber[0] != '0' && phoneNumber[0] != '+')
            {
                phoneNumber = "0" + phoneNumber;
            }
            return phoneNumber;
        }
        public static string IsValidCode(string Code)
        {
            do
            {
                bool isValid = Code.Length == 10;
                if (isValid)
                {
                    for (int i = 0; i < Code.Length; i++)
                    {
                        if (!char.IsDigit(Code[i]))
                        {
                            if (!(Code.Length == 10))
                            {
                                isValid = false;
                                break;
                            }
                        }

                    }
                }
                if (!isValid)
                {
                    throw new Exception(message: "Invalid nationalCode please try again: ");


                }
                if (isValid)
                {
                    break;

                }
            }
            while (true);
            return Code;
        }

    }

}


