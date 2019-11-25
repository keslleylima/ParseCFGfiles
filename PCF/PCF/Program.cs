using System;
using System.IO;

namespace PCF
{
    class Program
    {
        static void Main(string[] args)
        {
            string projectPath = "C:\\Users\\kesll\\Downloads\\LANG-20191125T204543Z-001\\LANG";
            string[] cfgFilesPath = GetFiles(projectPath);
            string[] fileCfg;

            foreach (string file in cfgFilesPath)
            {
                // Console.WriteLine(file);
                fileCfg = OpenFile(file);
                foreach(string line in fileCfg)
                {

                    string tmp = line.(new string[] { "->", "true" });
                }

                }
            }
        public static string[] GetFiles(string directoryPath)
        {
            string[] files = Directory.GetFiles(directoryPath, "*.dot", System.IO.SearchOption.AllDirectories);

            return files;
        }
        private static string[] OpenFile(string path)
        {
            string[] lines;
            try
            {
                lines = System.IO.File.ReadAllLines(path);
            }
            catch (FileNotFoundException execption)
            {
                throw execption;
            }
            return lines;
        }
    }

}

