using System;
using System.Timers;

namespace GPTtimer
{
    class Program
    {
        static System.Timers.Timer timer;

        static void Main()
        {
            // Create a timer that fires every 1 second
            timer = new System.Timers.Timer(1000);

            // Set the event handler for the Elapsed event
            timer.Elapsed += OnTimerElapsed;

            // Start the timer
            timer.Start();

            // Wait for the user to press a key
            Console.WriteLine("Press any key to stop the timer...");
            Console.ReadKey();

            // Stop the timer
            timer.Stop();

            Console.WriteLine("Timer stopped.");
        }

        static void OnTimerElapsed(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Timer ticked at {0}", e.SignalTime);
        }
    }
}