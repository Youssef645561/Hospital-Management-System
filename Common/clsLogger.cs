using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public static class clsLogger
    {
        public static bool Log(string message, EventLogEntryType icon = EventLogEntryType.Information, string sourceName = "Jo")
        {
            bool IsSucceeded = false;
            try
            {
                if (!EventLog.SourceExists(sourceName))
                    EventLog.CreateEventSource(sourceName, "Application");

                EventLog.WriteEntry(sourceName, message, icon);
                IsSucceeded = true;
            }
            catch
            {
                IsSucceeded = false;
            }
            return IsSucceeded;
        }
    }
}
