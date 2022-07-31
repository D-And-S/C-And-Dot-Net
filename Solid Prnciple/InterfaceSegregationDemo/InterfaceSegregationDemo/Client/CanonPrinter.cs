using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationDemo.Client
{
     /*
         1. let's assume this printer does not have faxcontent and printduplex capability 
         2. but yet i have to implement all the method 
         3. in this situation we can make the another interface for FaxContent 
     */
    internal class CanonPrinter : IPrinTasks, FaxTask
    {
        public bool FaxContent(string content)
        {
            throw new NotImplementedException();
        }

        public bool PhotoCopyContent(string content)
        {
            throw new NotImplementedException();
        }

        public bool PrintContent(string content)
        {
            throw new NotImplementedException();
        }

        public bool ScanContent(string content)
        {
            throw new NotImplementedException();
        }
    }
}
