namespace NancyNowin
{
    using System;

    using Microsoft.Owin.Hosting;

    class Program
    {
        static void Main(string[] args)
        {
            var options = new StartOptions
            {
                ServerFactory = "Nowin",
                Port = 1280
            };

            using (WebApp.Start<Startup>(options))
            {
                Console.WriteLine("Running a http server on port 1280");
                Console.ReadKey();
            }
        }
    }
}
