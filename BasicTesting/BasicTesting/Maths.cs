using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTesting
{
    public class Maths
    {

        //method -- returning -- string (non - static = return statement)
        public string printMsg (string msg)
        {
            Console.WriteLine("Test: " + msg);
            return msg;
        }

        //method 2 -- returning -- 2 ints
        public int addVals(int a, int b)
        { 
            int result = a + b;
            Console.WriteLine("Values added: " + result);
            return result;
        }

    }
}
