using System;
using System.IO;

public delegate void PrintString(string s);

namespace CSharpAllExamples.Examples
{
    public class DelegateUse
    {
        static FileStream fs;
        static StreamWriter sw;

        // this method prints to the console
        public void WriteToScreen(string str)
        {
            Console.WriteLine("The String is: {0}", str);
        }

        //this method prints to a file
        public void WriteToFile(string s)
        {
            string strOutPutPath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\OutPut\\TMP01.txt";
            fs = new FileStream(strOutPutPath, FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(fs);
            sw.WriteLine(s);
            sw.Flush();
            sw.Close();
            fs.Close();
        }

        // this method takes the delegate as parameter and uses it to
        // call the methods as required
        public void sendString(PrintString PS)
        {
            PS("Hello World");
        }

    }
}
