/* Method
 * 1) Select opened web browser.  
 * 2) Create bookmark folder with today's date as name.
 * 3) Individually add tab sessions to the folder.
 * 4) Close tab once added (Ctrl + w)
 */

// https://github.com/TestStack/White
// https://docs.microsoft.com/en-us/dotnet/framework/ui-automation/ui-automation-overview?redirectedfrom=MSDN
// https://archive.codeplex.com/?p=inputsimulator

using WindowsInput;
using System;


namespace Browser_Tab_Session_Save
{
    class Program
    {
        static void Main(string[] args)
        {
            Program main_program = new Program();
            main_program.test();
        }

        public void test()
        {
            var sim = new InputSimulator();
            sim.Mouse.MoveMouseBy(5, 34);
            System.Threading.Thread.Sleep(1000);
            sim.Mouse.MoveMouseBy(10, 34);
            System.Threading.Thread.Sleep(1000);
            sim.Mouse.MoveMouseBy(50, 34);
        }
        public void create_bookmark_folder()
        {
            string folder_name = DateTime.Now.ToString("yyyy-MM-dd h:mm:ss tt");
            
        }

    }
}
