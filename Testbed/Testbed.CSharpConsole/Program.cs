﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testbed.CSharpConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare an implicitly-typed variable but don't initialize it
            // notice that the ide will say that Implicitly-typed local variables must be initialized
            var x;
            x = 5;
        }
    }
}