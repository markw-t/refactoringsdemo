using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluePencilDemo
{
    class Temp
    {
        public int Method1(string arg)
        {
            int retval = 0;
            if(arg.Length > 0 && arg.StartsWith("a"))
            {
                retval = arg.Length;
            }

            return retval;
        }

        public int Method2(string arg2)
        {
            int retval = 0;
            if(arg2.Length >0 && arg2.StartsWith("b"))
            {
                retval = arg2.Length;
            }
            return retval;
        }

        public int RefactoredMethod(string arg, string test)
        {
            int retval = 0;
            if (arg.Length > 0 && arg.StartsWith(test))
            {
                retval = arg.Length;
            }
            return retval;

        }



    }
}
