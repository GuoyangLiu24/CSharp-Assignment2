using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guoyang_liu_exercise2
{
    public static class StringBuilderExtension
    {
        public static int StringBuilder(this string str)
        {
            return str.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }// end class
}//end namaspace
