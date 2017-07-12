using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.Common
{
    //Static classes dont need to be instantiated good for general purpose classes
    public static class StringHandler
    {
        //all methods in static classes need to be static also
        //Adding this infront of the first parameter creates an extension method and now allows 
        //insertspaces to be called properly
        public static string InsertSpaces(this string source)
        {
            //Create a new return value
            string result = string.Empty;
            //Skips processing if the string is null or empty
            if (!string.IsNullOrWhiteSpace(source))
            {
                //If the string contains something it loops looking for uppercase
                foreach (char letter in source)
                {
                    //if it finds an upper case letter it will insert a space after
                    if (char.IsUpper(letter))
                    {
                        //trim any spaces already there(prevent double spaces)
                        result = result.Trim();
                        result += " ";
                    }
                    result += letter;
                }
                //trim spaces from beginning and end of result if any
                result = result.Trim();
            }
            //after loop it returns the result
            return result;
        }
    }
}
