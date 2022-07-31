using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationDemo.Client
{
    internal class HpPrinter : IPrinTasks
    {
        public bool FaxContent(string content)
        {
            Console.WriteLine("Fax Content");
            return true;
        }

        public bool PhotoCopyContent(string content)
        {
            Console.WriteLine("PhotoCopy Content");
            return true;
        }

        public bool PrintContent(string content)
        {
            Console.WriteLine("PrintConent");
            return true;
        }

        public bool PrintDuplexContent(string content)
        {
            Console.WriteLine("PrintDuplexConent");
            return true;
        }

        public bool ScanContent(string content)
        {
            Console.WriteLine("ScanContent");
            return true;
        }
    }
}
