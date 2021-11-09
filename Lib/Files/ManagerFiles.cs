using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Lib.Files
{
    public class ManagerFiles
    {
        public void RegisterFile(string name, string text)
        {
            string path = "C:\\Users\\João Denílson\\Documents" + name + ".txt";

            if (File.Exists(path))
            {
                using (StreamWriter wr = File.AppendText(path))
                {
                    wr.WriteLine(text);
                }
            }
            else
            {
                using (StreamWriter wr = new StreamWriter(path))
                {
                    wr.WriteLine(text);
                }
            }
        }

        public string[] ReadFiles(string name)
        {
            string path = "C:\\Users\\João Denílson\\Documents" + name + ".txt";
            return File.ReadAllLines(path);
        }
    }
}
