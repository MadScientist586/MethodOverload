using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MethodOverload
{
    internal class Methods
    {
        public static int Add(int x, int y)
        {
            return x + y;
      
        
        }
    
        public static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }
    
    
        public static string Add(int x, int y, bool z)
        {
            if (x + y == -1 || x + y == 1)
            {
                return $"{x + y} dollar";
            }
            else
            {
                return $" {x = y} dollars"; 
            }
            


        } 
    }
}
