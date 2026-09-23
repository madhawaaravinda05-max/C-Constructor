using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Car
    {
        public int id { get; set; }
        public string name { get; set; }
        public string color { get; set; }
        public string publish {  get; set; }
        public string HorsePower { get; set; }

        public Car() {}

        public Car (int id,string name,string color,string publish,string HorsePower)
        {
            this.id = id;
            this.name = name;
            this.color = color;
            this.publish = publish;
            this.HorsePower = HorsePower;
        }

        public void Display()
        {
            Console.WriteLine($"id:{id}");
            Console.WriteLine($"name:{name}");
            Console.WriteLine($"color:{color}");
            Console.WriteLine($"publish:{publish}");
            Console.WriteLine($"HorsePower:{HorsePower}");
        }
    }
}
