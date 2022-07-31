using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationDemo
{
    internal interface IPrinTasks
    {
        bool PrintContent(string content);
        bool ScanContent(string content);

        //bool FaxContent(string content);
        bool PhotoCopyContent(string content);
        // bool PrintDuplexContent(string content);
    }

    interface FaxTask
    {
        bool FaxContent(string content);
    }

    interface PrintDuplex
    {
        bool PrintDuplexContent(string content);
    }
}
