using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Reflection;
using System.Diagnostics;

namespace AFPA.MVCUI.Complements
{
    public static class Journal
    {
        public static void EcrireEvenement(string message)
        {
            string nomApplication = ((AssemblyTitleAttribute)Assembly.GetExecutingAssembly().GetCustomAttribute(typeof(AssemblyTitleAttribute))).Title;

            if (!EventLog.SourceExists(nomApplication))
            {
                EventLog.CreateEventSource(nomApplication, string.Empty);
            }

            EventLog log = new EventLog();
            log.Source = nomApplication;
            log.WriteEntry(message);
        }
    }
}