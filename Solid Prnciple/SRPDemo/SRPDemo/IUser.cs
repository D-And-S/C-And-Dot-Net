using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPDemo
{
    interface IUser
    {
        /*
             to register or login a user we need these 4 method generally 
            
             but if we look deeply this class IUser we only need login and register method for this class

             but log Error and SendMail does not belongs to or to be part of  this class so we defantely 
             
             break down to seperate phases 
         */
        bool Login(string username, string password);
        bool Register(string username, string password, string email);
        //void LogError(string error);
        //bool SendMail(string emailContent);
    }

    interface ILogger
    {
        void LogError(string error);
    }

    interface IEmail
    {
        bool SendMail(string emailContent);
    }
}
