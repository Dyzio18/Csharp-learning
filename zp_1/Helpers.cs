using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zp1_lab
{
    class Helpers
    {
        public static string InsertSpaceBeforeUpperCase(string str)
        {
            var sb = new StringBuilder();
            char previousChar = char.MinValue;
            foreach (char c in str)
            {
                if (char.IsUpper(c))
                {
                    if (sb.Length != 0 && previousChar != ' ')
                    {
                        sb.Append(' ');
                    }
                }
                sb.Append(c);
                previousChar = c;
            }
            return sb.ToString();
        }

        /* public static string parseJobNames(int job)
         {
             switch(job){
         *      case 1: return ""
         * 
         * }
         }*/
    }
}
