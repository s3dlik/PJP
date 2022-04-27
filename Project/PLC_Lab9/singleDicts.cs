using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLC_Lab9
{
    
    public class singleDicts
    {

        public Dictionary<string, string> stackValues { get; set; }
        private static singleDicts instance = null;

        public singleDicts()
        {
            this.stackValues = new Dictionary<string, string>();
        }
        public static singleDicts returnInstance()
        {
            if(instance == null)
            {
                instance = new singleDicts();
            }
            return instance;
        }
    }
}
