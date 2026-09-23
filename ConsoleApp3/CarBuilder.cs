using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class CarBuilder
    {
        private Car car;
        public CarBuilder()
        {
            car = new Car();   
        }
        public CarBuilder SetId(int id)
        {
            car.id = id;
            return this;
        }
        public CarBuilder SetName(string name)
        {
            car.name = name;
            return this;
        }
        public CarBuilder SetColor(string color)
        {
            car.color = color;
            return this;
        }
        public CarBuilder SetPublish(string publish)
        {
            car.publish = publish;
            return this;
        }
        public CarBuilder SetHorsePower(string HorsePower)
        {
            car.HorsePower = HorsePower;
            return this;
        }

        public Car Build()
        {
            return car;
        }
    }
}
