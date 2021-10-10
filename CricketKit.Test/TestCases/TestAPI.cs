using System;
using System.Collections.Generic;
using System.Text;

namespace CricketKit.Test.TestCases
{
    public static class TestAPI
    {
        /// <summary>
        /// Get test Method Name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string GetCurrentMethodName([System.Runtime.CompilerServices.CallerMemberName] string name = "")
        {
            return name;
        }
    }
}
