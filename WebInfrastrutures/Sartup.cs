using System;

namespace SE.WebInfrastrutures
{
    public class Sartup
    {
        public static void Main()
        {
            int x = 0;

            if (x >= 1)
                Environment.Exit(0);

            Console.WriteLine("Web Infrastruture is running...");
            Console.ReadKey();
        }
    }
}
