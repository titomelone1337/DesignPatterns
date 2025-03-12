using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class logClass {

        private static logClass? instance = null;
        private List<LogEntry> logs;

        private logClass() { 

            logs = new List<LogEntry>();
        }

        public static logClass? Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new logClass();
                }
                return instance;

            }
        }

        public void AddLog(string eventDescription, string state)
        {
            LogEntry log = new LogEntry(eventDescription, state);
            logs.Add(log);
        }

        public List <LogEntry> GetAllLogs()
        {
            return logs;
        }

    }



}
