using System;
using System.Collections.Generic;
using System.Text;

namespace DevSkillAdmissionTest
{
    public static class MethodExtension
    {
        public static string StringToPascal(this string text)
        {
            try
            {
                string[] words = text.Split(' ');

                StringBuilder returnStr = new StringBuilder();

                foreach (string wrd in words)
                {
                    returnStr.Append(wrd.Substring(0, 1).ToUpper());
                    returnStr.Append(wrd.Substring(1).ToLower());

                }
                return returnStr.ToString();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }
    }
}
