using System;
using System.Collections.Generic;
using System.Text;

namespace BlueFlame.Classes.DatabaseObjects
{
    public enum LogMessage
    {
       MediaCreated = 1000,
       MediaCreateAbort = 1001, 
       UserLogonSuccess = 2000, 
       UserLoggedOff = 2001,
       UserLogonAbort = 2002, 
       UserLogonError = 2003,    
       UserLogonErrorEmptyName = 2004, 
       LicenseNew = 3000,
       LicenseOld = 3001,
       LicenseNotAvailable = 3002  
    }
}
