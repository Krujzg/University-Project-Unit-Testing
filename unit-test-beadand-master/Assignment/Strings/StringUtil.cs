using System.Linq;
using System.Text;

/**
 * https://hu.wikipedia.org/wiki/Palindrom
 */
namespace Assignment.Strings
{
    public class StringUtil
    {
        ///// <summary>
        ///// Checks if the string passed in is a palindrom or not.
        ///// </summary>
        ///// <param name="str"></param>
        ///// <returns>True if the passed in string is a palindrom, otherwise false.</returns>
        //public bool IsPalindrom(string str)
        //{
        //    var reverse = new StringBuilder(str).ToString().Reverse<char>().ToString();
        //    return str.Equals(str);
        //}

        //az egész függvényt cseréltem
        /// <summary>
        /// Checks if the string passed in is a palindrom or not.
        /// </summary>
        /// <param name="str"></param>
        /// <returns>True if the passed in string is a palindrom, otherwise false.</returns>
        public bool IsPalindrom(string value)
        {
            int min = 0;
            int max = value.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                char a = value[min];
                char b = value[max];
                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                min++;
                max--;
            }
        }

    }
}
