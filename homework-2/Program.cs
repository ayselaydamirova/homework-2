using System;
using System.Collections.Generic;
using System.IO;

namespace homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<string> list = new List<string>();
                string[] filesLocal = Directory.GetFiles(Directory.GetCurrentDirectory(), "", SearchOption.TopDirectoryOnly);
                foreach (string file in filesLocal)
                {
                    list.Add(file);
                }
                String[] str = list.ToArray();
                Console.WriteLine("{" + string.Join(",", list) + "}");
                     

            }
            catch (Exception e)
            {

                Console.WriteLine("Process finished with error --> {0}", e.ToString());
            }
        }
    }
}
