using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using log4net;
using System.Threading.Tasks;


[assembly: log4net.Config.XmlConfigurator(Watch = true)]


namespace KurtosysSeleniumTest
{
    public class Logging
    {
        protected static readonly ILog Log = LogManager.GetLogger(typeof(Logging));
        private static double secs = 3;

        public static void Fatal(String Msg)
        {

            Log.Fatal("Start log FATAL...");
            Console.WriteLine(Msg);
            Thread.Sleep(TimeSpan.FromSeconds(secs)); // Sleep some secs
            ;
        }
        public static void Error(Exception Msg)
        {
            Log.Error(Msg);
            Console.WriteLine(Msg);
            Thread.Sleep(TimeSpan.FromSeconds(secs));
        }
        public static void Warn(String Msg)
        {
            Log.Warn(Msg);
            Console.WriteLine(Msg);
            Thread.Sleep(TimeSpan.FromSeconds(secs));
        }
        public static void Infor(String Msg)
        {
            Log.Info(Msg);
            Console.WriteLine(Msg);
            Thread.Sleep(TimeSpan.FromSeconds(secs));
        }
        public static void Debug(String Msg)
        {
            Log.Debug(Msg);
            Console.WriteLine(Msg);
            Thread.Sleep(TimeSpan.FromSeconds(secs));
            Console.WriteLine("Press any key to close the application");
        }
    }
}
