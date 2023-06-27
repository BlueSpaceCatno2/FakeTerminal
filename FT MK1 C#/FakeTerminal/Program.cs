using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FakeTerminal
{
    internal static class Program
    {
        public static void Main()
        {
            Console.WriteLine($"Console Manager ({System.Reflection.Assembly.GetExecutingAssembly().GetName().Version})");
            Console.WriteLine("Please select a console type. Valid types are: BSCC, WAC");

            string type = "";
            while (true)
            {
                type = Console.ReadLine();

                if (type == "BSCC" || type == "WAC")
                {
                    break;
                }

                Console.WriteLine("Incorrect type, please try again.");
            }

            if (type == "BSCC")
            {
                BSCConsole();
            }

            if (type == "WAC")
            {
                WAConsole();
            }
        }


        public static void BSCConsole()
        {
            Console.Clear();

            Random res = new Random();

            // String that contain both alphabets and numbers
            String sti = "abcdefghijklmnopqrstuvwxyz0123456789";
            int size = 8;

            // Initializing the empty string
            String randomstring = "";

            for (int i = 0; i < size; i++)
            {

                // Selecting a index randomly
                int x = res.Next(sti.Length);

                // Appending the character at the 
                // index to the random alphanumeric string.
                randomstring = randomstring + sti[x];
            }




            string User = "BlueSpaceCat";
            string Password = "1899";
            Console.WriteLine("Hello User " + "dsfmsdklf" + randomstring + "213124" + randomstring + "sjafh3124" + randomstring + "dsfkjsdf");
            Console.WriteLine("OS build: " + randomstring);
            Console.WriteLine("Please insert Username");

            string UserB = Console.ReadLine();



            if (UserB == User)
            {
                Console.WriteLine("CORRECT SIR! NOW INSERT PASSWORD.");
            }

            string PasswordB = Console.ReadLine();


            if (PasswordB == Password)
            {
                Console.WriteLine("CORRECT SIR! PROCEEDING TO UNLOCK DEVICE");
                Console.Clear();
                Console.WriteLine("WELCOME SIR BlueSpaceCat TO THE BSC ULTRAHUBOS TERMINAL");
                System.Threading.Thread.Sleep(1300);

                Console.WriteLine("Loading datalogs.");
                System.Threading.Thread.Sleep(1300);
                Console.Clear();
                Console.WriteLine("WELCOME SIR BlueSpaceCat TO THE BSC ULTRAHUBOS TERMINAL");


                Console.WriteLine("Loading datalogs. .");
                System.Threading.Thread.Sleep(1300);
                Console.Clear();
                Console.WriteLine("WELCOME SIR BlueSpaceCat TO THE BSC ULTRAHUBOS TERMINAL");


                Console.WriteLine("Loading datalogs. . .");
                System.Threading.Thread.Sleep(1300);
                Console.Clear();

                Console.WriteLine("WELCOME SIR BlueSpaceCat TO THE BSC ULTRAHUBOS TERMINAL");

                Console.WriteLine("Loading datalogs.");
                System.Threading.Thread.Sleep(1300);
                Console.Clear();
                Console.WriteLine("WELCOME SIR BlueSpaceCat TO THE BSC ULTRAHUBOS TERMINAL");


                Console.WriteLine("Loading datalogs. .");
                System.Threading.Thread.Sleep(1300);
                Console.Clear();
                Console.WriteLine("WELCOME SIR BlueSpaceCat TO THE BSC ULTRAHUBOS TERMINAL");


                Console.WriteLine("Loading datalogs. . .");
                System.Threading.Thread.Sleep(1300);
                Console.Clear();

                Console.WriteLine("WELCOME SIR BlueSpaceCat TO THE BSC ULTRAHUBOS TERMINAL");

                Console.WriteLine("Loading datalogs.");
                System.Threading.Thread.Sleep(1300);
                Console.Clear();
                Console.WriteLine("WELCOME SIR BlueSpaceCat TO THE BSC ULTRAHUBOS TERMINAL");


                Console.WriteLine("Loading datalogs. .");
                System.Threading.Thread.Sleep(1300);
                Console.Clear();
                Console.WriteLine("WELCOME SIR BlueSpaceCat TO THE BSC ULTRAHUBOS TERMINAL");


                Console.WriteLine("Loading datalogs. . .");
                System.Threading.Thread.Sleep(1300);
                Console.Clear();
                Console.WriteLine("Datalogs Loaded");
                System.Threading.Thread.Sleep(1300);
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Engaging BSC TERMINAL");
                    System.Threading.Thread.Sleep(800);
                    Console.WriteLine("Please insert command");
                    System.Threading.Thread.Sleep(800);
                    String console = Console.ReadLine();
                    System.Threading.Thread.Sleep(800);
                    Console.WriteLine("Proscessing. " + console);
                    System.Threading.Thread.Sleep(800);
                    Console.WriteLine("Proscessing.. " + console);
                    System.Threading.Thread.Sleep(800);
                    Console.WriteLine("Proscessing... " + console);
                    System.Threading.Thread.Sleep(800);
                    Console.Clear();
                    Random rand = new Random();

                    // Choosing the size of string
                    // Using Next() string
                    int stringlen = rand.Next(4, 10);
                    int randValue;
                    string str = "";
                    char letter;
                    for (int i = 0; i < stringlen; i++)
                    {

                        // Generating a random number.
                        randValue = rand.Next(0, 26);

                        // Generating random character by converting
                        // the random number into character.
                        letter = Convert.ToChar(randValue + 65);

                        // Appending the letter to string.
                        str = str + letter;
                    }


                    Console.WriteLine("Error operating command" + console + "error" + str);
                    System.Threading.Thread.Sleep(2300);
                }
            }
        }


        public static void WAConsole()
        {
            Console.WriteLine("Western's Advanced Console (1.0.0.0)");
            Console.WriteLine("Please enter your credentials:");
            
            while (true)
            {
                Console.WriteLine("Username:");
                var user = Console.ReadLine();
                Console.WriteLine("Password:");
                var pass = Console.ReadLine();

                using (PrincipalContext pc = new PrincipalContext(ContextType.Machine, Environment.MachineName))
                {
                    Console.WriteLine("Please wait while the program verifies the credentials.");
                    if (pc.ValidateCredentials(user, pass))
                    {
                        break;
                    }
                }

                Console.WriteLine("Incorrect credentials, please try again");
            }

            Console.WriteLine("Starting secure session.");
            Console.WriteLine("Detected system console, switching.");

            ConsoleColor color = Console.ForegroundColor;
            ProcessStartInfo startinfo = new ProcessStartInfo("cmd.exe");
            startinfo.CreateNoWindow = false;
            startinfo.UseShellExecute = false;
            Process p = Process.Start(startinfo);
            p.WaitForExit();
            Console.ForegroundColor = color;


        }

        
    }

}
