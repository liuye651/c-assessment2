using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_1c
{
    class nestedcl
    {


        // Inner class
        public class Inner_class
        {

            // Static method of Inner class
           
             public  static string method1()
            {
                
                nestedcl obj = new nestedcl();

                return "Message from a nested inner class";
                
                
            }
        }

    }
}

