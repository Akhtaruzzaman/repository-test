using System;
using System.Collections.Generic;
using System.Text;

namespace CommonLibrary
{
    public static class Functions
    {
        public static int toInt(this string s)
        {
            try
            {
                return Convert.ToInt32(s);
            }
            catch (Exception)
            {

                return 0;
            }
        }
        public static long toLong(this string s)
        {
            try
            {
                return Convert.ToInt64(s);
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public static string ToUperString(this string val)
        {
            if (string.IsNullOrWhiteSpace(val))
            {
                return "";
            }
            else
            {
                return val.ToUpper();
            }
        }
    }
}
