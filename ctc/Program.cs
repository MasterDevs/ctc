using System;

namespace Ctc
{
    internal class Program
    {
        public const string APP_ID = "com.MasterDevs.Ctc";

        public static void Main(string[] args)
        {

            if (args == null || args.Length == 0)
            {

                var toaster = new Toaster();
                toaster.TryCreateShortcut();

                Run(toaster);
            }
            else
            {
                var sep = " ";
                Console.WriteLine($"Args! {string.Join (sep, args)}");
                Console.WriteLine("Press enter");
                Console.ReadLine();
            }
        }

        private static void Run(Toaster toaster)
        {
            bool run = true;

            Console.CancelKeyPress += (s, e) => run = false;

            while (run)
            {
                var input = Console.In.ReadLine();
                if (input == null)
                {
                    run = false;
                    continue;
                }

                Console.WriteLine("read:  " + input);
                toaster.ShowToast("Hello world", input ?? "nothing to see here");
            }
        }
    }
}