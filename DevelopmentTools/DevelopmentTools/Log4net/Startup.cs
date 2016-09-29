namespace Log4Net
{
    using log4net;
    using log4net.Config;
    using System;

    internal class Log4NetExample
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(Log4NetExample));

        internal static void Main()
        {
            XmlConfigurator.Configure();

            Log.Info("Logging information!");

            try
            {
                throw new Exception("Exception!");
            }
            catch (Exception ex)
            {
                Log.Error("Error message!", ex);
            }

            Console.WriteLine("Press any key to exit:");
            Console.ReadKey();
            Console.Clear();

            /* or
            BasicConfigurator.Configure();
            Log.Debug("Debug msg");
            Log.Error("Error msg");
             */
        }
    }
}