using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generate
{
    /// <summary>
    /// Author: Adrian A. Jaspio
    /// Donation link: https://www.paypal.com/paypalme/adrianjaspio
    /// </summary>
    public class RandomGen
    {
        string sourceA = "abcdefghijklmnopqrstuvwxzy1234567890";
        string sourceB = "ABCDEFGHIJKLMNOPQRSTUVWXZY";
        string sourceC = @"!@#$%^&*(){}:""|<>?~[];',./\`-=+_ñÑ";
        string finalSource;

        /// <summary>
        /// Create new instance with default setting.
        /// </summary>
        public RandomGen()
        {
            finalSource = sourceA;
        }

        /// <summary>
        /// Create new instance with desired setting.
        /// </summary>
        /// <param name="opt"></param>
        public RandomGen(Option opt)
        {
            switch (opt)
            {
                case Option.Default:
                    finalSource = sourceA;
                    break;
                case Option.IncludeCapital:
                    finalSource = sourceA + sourceB;
                    break;
                case Option.IncludeCapetalAndSpecial:
                    finalSource = sourceA + sourceB + sourceC;
                    break;
            }
        }

        /// <summary>
        /// Generate a random string
        /// </summary>
        /// <param name="length">Length of generated string default is 6</param>
        /// <returns>string</returns>
        public string Gen(int length = 6)
        {
            var output = "";
            for (int i = 0; i < length; i++)
            {
                output += finalSource[new Random().Next(0, finalSource.Length)];
            }
            return output;
        }
    }

    /// <summary>
    /// Select your setting.
    /// </summary>
    public enum Option
    {
        /// <summary>
        /// a - z and 0 - 9
        /// </summary>
        Default,
        /// <summary>
        /// a - z, A - Z, and 0 - 9
        /// </summary>
        IncludeCapital,
        /// <summary>
        /// a - z, A - Z, Special Character, and 0 - 9
        /// </summary>
        IncludeCapetalAndSpecial
    }
}
