using System;
using System.IO;
using System.Linq;

namespace ConsoleApp1
{
  public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            const string filePath = "TestTextFile.txt";
            Program p = new Program();
            p.startProcess(filePath);
        }
       public void startProcess(string filePath)
        {
            if (!string.IsNullOrEmpty(filePath))
            {
                string dir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName;
                string file = dir + "/" + filePath;
                if (File.Exists(file))
                {
                    FileTextReverser reverser = new FileTextReverser();
                    string reverseText = reverser.ReverseFileContents(file);
                    Console.WriteLine(reverseText);
                    using (StreamWriter sw = File.AppendText(file))
                    {
                        sw.WriteLine(reverseText);
                    }
                }
            }
        
        }
    }

   
    public class FileTextReverser
    {
        public string ReverseFileContents(string filepath)
        {
            // TODO: read text file, reverse the text, save reversed text back to the same file

            // TODO: return the reversed text
            if (!string.IsNullOrEmpty(filepath) && File.Exists(filepath))
            {
                using (StreamReader r = new StreamReader(filepath))
                {
                    string content = r.ReadToEnd();
                    if (string.IsNullOrEmpty(content)) return null;
                    r.Dispose();
                    return new string(content.Reverse().ToArray());
                }

            }
            else
            {
                return null;
            }

            
           
        }

    }
}
