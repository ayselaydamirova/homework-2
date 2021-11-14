using System;
using System.Text.Json;

namespace Homework_12._11._2001
{
    public class JsonData
    {
        public int Number { get; set; }
        public string Text { get; set; }
    }


    class Program
    {


        static void Main(string[] args)
        {
            var JsonData = new JsonData
            {
                Number = 11,
                Text = "Hello"
            };

            string JsonString = JsonSerializer.Serialize(JsonData);
            Console.WriteLine(JsonString);
        }

    }
}

  
