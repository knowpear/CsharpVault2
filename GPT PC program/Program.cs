//To open the www.microsoft.com website in the Edge browser, wait for 5 seconds, and then close the browser
using System.Diagnostics;
class Program
{
    static void Main()
    {
        // Open Microsoft Edge with www.microsoft.com
        Process.Start(@"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe", "www.microsoft.com");

        // Wait for 5 seconds
        Console.WriteLine("Waiting for 5 seconds...");
        System.Threading.Thread.Sleep(5000);

        // Close Microsoft Edge
        foreach (var process in Process.GetProcessesByName("msedge"))
        {
            process.Kill();
        }
    }
}
