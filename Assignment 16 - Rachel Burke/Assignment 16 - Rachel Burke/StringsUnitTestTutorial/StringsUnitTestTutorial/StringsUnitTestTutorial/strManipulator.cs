using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsUnitTestTutorial
{
    public class strManipulator
    {
        public string mString { get; set; }

        public strManipulator(string str)
        {
            mString = str;
        }

        public bool search(string strTarget)
        {
            return mString.Contains(strTarget); //correct
            //return mString.Contains(""); //injected fault - fails string search test
        }

        public string stripper(string strTarget, string replacement)
        {
            return mString.Replace(strTarget, replacement); //correct
            //return mString.Replace(replacement, strTarget); //injected fault - fails string stripper test
        }

        public string wrapper(string str1, string str2)
        {
           return str1 + mString + str2; //correct
           //return str1 + str2 + mString; //injected fault - fails string wrapper test
        }

        public string capitalizer(string strTarget)
        {
            return strTarget.ToUpper(); //correct
            //return strTarget.First().ToString().ToUpper(); //injected fault - fails capitalizer test
        }

    }
}
