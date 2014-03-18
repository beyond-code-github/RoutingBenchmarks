namespace SuperscribeNowin
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
                Port = 1281
            };

            using (WebApp.Start<Startup>(options))
            {
                Console.WriteLine("Running a http server on port 1281");
                Console.ReadKey();
            }
        }
    }
}
