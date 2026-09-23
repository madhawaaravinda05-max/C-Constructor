
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class GassoleenCarBuilder: CarBuilder
    {
        private Car car = new Car();
        public GassoleenCarBuilder SetId(int id)
        {
            car.id = id;
            return this;
        }
        public GassoleenCarBuilder SetName(string name)
        {
            car.name = name;
            return this;
        }

        public GassoleenCarBuilder SetColor(string color)
        {
            car.color = color;
            return this;
        }

        public GassoleenCarBuilder SetPublish(string publish)
        {
            car.publish = publish;
            return this;
        }

        public GassoleenCarBuilder SetHorsePower(string HorsePower)
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
