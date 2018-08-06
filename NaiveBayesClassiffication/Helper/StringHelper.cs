using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaiveBayesClassiffication.Helper
{
    public static class StringHelper
    {
        public static string GetOnlyLetterAndSpace(string content)
        {
            string result = "";
            content = content.Replace("\\r", " ").Replace("\\n", " ");
            foreach (char c in content)
            {
                if (Char.IsLetter(c) || Char.IsWhiteSpace(c))
                {
                    result += c;
                }
            }
            return result;
        }
        public static int GetCountInContent(string content, string find)
        {
            int result = 0;
            try
            {
                string dummy = content.Replace(find, "");
                result = content.Length - dummy.Length;
                return result;
            }
            catch(Exception e)
            {
                Console.WriteLine("BURADA BURADA BURADA ************** GetCountInContent ! : " + e.Message);
                return result;
            }
        }
    }
}
