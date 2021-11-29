using System;
using System.Diagnostics;
using System.IO;
using System.Net;

namespace CalculatorCore.Log
{
    public interface ILog
    {
        void Log(string info);
    }

    class FileLog : ILog
    {
        public void Log(string info)
        {
            File.AppendAllText("log.db", $"{info}{Environment.NewLine}");
        }
    }

    public class DebugLog : ILog
    {
        public void Log(string info)
        {
            Debug.WriteLine($"{info}{Environment.NewLine}");
        }
    }

    class VoluntaryLog :ILog
    {
        private ILog log;

        public VoluntaryLog(ILog log) => this.log = log;
        
        public void Log(string info)
        {
            log?.Log(info);
        }
    }
}