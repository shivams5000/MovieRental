﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMovieStore.Operation
{
    public class Checks
    {
        // to check empty textbox
        public static bool EmptyField(string value)
        {
            return value.Equals("");
        }

        // to check valid number
        public static bool checkNumber(string num)
        {
            try
            {
                int.Parse(num);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // check long mobile number >= 10 digits
        public static bool checkPhoneNumber(string num)
        {
            try
            {
                long.Parse(num);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // check valid date
        public static bool checkDateString(string dt)
        {
            try
            {
                DateTime.Parse(dt);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
