using System;
using System.IO;
using System.Reflection;

namespace Jaco
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string dirName = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "/Files";
            string[] fileNames = Directory.GetFiles(dirName);
            foreach(string name in fileNames)
            {
                TrimFile(name);
            }
            


        }
        private static void TrimFile(string name)
        {
            StreamReader file = new StreamReader(name);
            string line;
            string newText = "";
            int counter = 0;
            while((line = file.ReadLine())!= null){
                if(counter<10)
                    counter++;
                else
                    newText += line+'\n';
                
            }
            file.Close();
            File.WriteAllText(name,newText);
            

        }
    }
}