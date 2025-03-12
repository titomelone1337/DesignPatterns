using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class LogEntry
    {

        public DateTime Timestamp { get; }
        public string eventDescription { get; }  

        public string State { get; }

        public LogEntry(string eventDescription, string state)
        {
            Timestamp = DateTime.Now;
            eventDescription = eventDescription;
            State = state;
        }

        public override string ToString()
        {
            return $"{Timestamp}: {eventDescription}, Estado: {State}";
        }
    }
}
