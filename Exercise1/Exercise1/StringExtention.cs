using System;

namespace Exercise1
{
    public static class StringExtention
    {
        public static string Reverse(this string s )
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string( charArray );
        }
    }
}