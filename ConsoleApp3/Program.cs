using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Car x1 = new Car(1001, "BMW M1", "Black", "BMW", "500");
            //x1.Display();

            /* Car x1 = new CarBuilder()
                 .SetId(1001)
                 .SetName("BMW M1")
                 .SetColor("Black")
                 .SetPublish("BMW")
                 .SetHorsePower("500");
             x1.Display();*/

            CarBuilder builder = new GassoleenCarBuilder();
            Car x1 = builder
                .SetId(1001)
                .SetName("BMW M1")
                .SetColor("Black")
                .SetPublish("BMW")
                .SetHorsePower("500")
                .Build();

        }
    }
}
