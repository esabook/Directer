using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;

namespace shutdown
{
	class Program
	{
		static void Main(string[] args)
		{

            var g = Process.GetCurrentProcess();
            String a = "";
            string conso = string.Empty;
            string conse = string.Empty;
            Process p = new Process();


            for (int i = 0; i < args.Length; i++)
            {
                a = a+ args[i] + " ";
            }

            if (File.Exists(Environment.CurrentDirectory + "\\" + g.ProcessName + "-x.exe"))
            {
                p.StartInfo.FileName = Environment.CurrentDirectory + "\\" + g.ProcessName + "-x.exe";
                p.StartInfo.Arguments = a;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.RedirectStandardError = true;
                p.StartInfo.UseShellExecute = false;

                p.Start();
                conse = p.StandardError.ReadToEnd();
                conso = p.StandardOutput.ReadToEnd();
                
                stre("====ARG=== : " + a);
                stre("====OUT=== : " + conso);
                stre("====ERR=== : " + conse);
                Console.WriteLine(conse+conso);
            }
            else { Console.WriteLine("Target Executable not Found."); }
        }
        static void stre(string u)
        {

            var g = Process.GetCurrentProcess();
            string fileName = Environment.CurrentDirectory + "\\" + g.ProcessName + "-x.txt";
            FileInfo fileInfo = new FileInfo(fileName);
            StreamWriter s = fileInfo.AppendText();
            s.WriteLine(u);
            s.Close();
            fileInfo.Refresh();
        }
	}
}
