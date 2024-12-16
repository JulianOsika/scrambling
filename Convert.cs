using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scramble
{
    public static class Convert
    {
        public static string Encrypt(string input, int shift)
        {
            string noSpaceInput = input.Replace(" ", "").ToLower();
            StringBuilder output = new StringBuilder();
            int index;
            int newIndex;

            foreach (char letter in noSpaceInput)
            {
                index = PolishAlphabet.letters.IndexOf(letter);

                if (index + shift > 33)
                    newIndex = index + shift -34;
                else
                    newIndex = index + shift;

                output.Append(PolishAlphabet.letters[newIndex]);
            }

            return output.ToString();
        }

        public static string Decrypt(string input, int shift)
        {
            string noSpaceInput = input.Replace(" ", "").ToLower();
            StringBuilder output = new StringBuilder();
            int index;
            int newIndex;

            foreach (char letter in noSpaceInput)
            {
                index = PolishAlphabet.letters.IndexOf(letter);

                if (index - shift < 0)
                    newIndex = index - shift + 34;
                else
                    newIndex = index - shift;

                output.Append(PolishAlphabet.letters[newIndex]);
            }

            return output.ToString();
        }
    }
}
