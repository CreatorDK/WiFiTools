using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WiFi_Tools
{
    public static class Logger
    {
        public static void WriteLine(string s)
        {
            string dt_now = DateTime.Now.ToString("hh:mm:ss");

            CheckFileExist();
            StreamWriter sw = File.AppendText(GetFullTextFileName());
            try
            {
                sw.WriteLine(dt_now + " " + s);
                sw.Close();
            }

            catch { }
        }

        public static void WriteEmptyLine()
        {
            CheckFileExist();
            StreamWriter sw = File.AppendText(GetFullTextFileName());
            try
            {
                sw.WriteLine("");
                sw.Close();
            }

            catch { }
        }

        private static void CheckFileExist()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

            if (!Directory.Exists(path + @"/WiFi Tools/Logs/"))
            {
                Directory.CreateDirectory(path + @"/WiFi Tools/Logs/");
            }

            if (!File.Exists(GetFullTextFileName()))
            {
                CreateTextFile(GetFullTextFileName());
            }
        }

        private static void CreateTextFile(string file)
        {
            File.CreateText(file);
        }

        private static string GetTextFileName()
        {
            string dt_now = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString();
            return dt_now;
        }

        public static string GetFullTextFileName()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string file = path + @"/WiFi Tools/Logs/Log" + GetTextFileName() + ".txt";
            return file;
        }
    }
}
