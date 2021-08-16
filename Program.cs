using System;
using System.IO;



namespace SobreStreamWriter
{
    class Program
    {
        static void Main(string[] args)
        {

            string SourcePath = @"C:\csharp\texto1.txt";
            string TargetPathh = @"C:\csharp\texto2.txt";

            try
            {
                string[] lines = File.ReadAllLines(SourcePath);
                using (StreamWriter sw = File.AppendText(TargetPathh))
                {

                    foreach (string line in lines)
                    {

                        sw.WriteLine(line.ToUpper());

                    }



                }
            }
            catch (IOException e)
            {
                System.Console.WriteLine("An Error Occurred!");
                System.Console.WriteLine(e.Message);
            }






        }
    }
}
