﻿namespace StudyCSharp
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    
    /// <summary>
    /// the Program class.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// the Main method.
        /// </summary>
        /// <param name="args">the args</param>
        private static void Main(string[] args)
        {
            Trace.WriteLine("Entering Main");
            JsonDotNet.TestJson();
            Trace.WriteLine("Exiting Main");
        }       
        
    }    
}
