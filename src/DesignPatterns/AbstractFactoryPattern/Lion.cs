using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class Lion : Carnivore
    {
        public override void Eat(Herbivore herbiVore)
        {
            Console.WriteLine(this.GetType().Name + " eats " + herbiVore.GetType().Name);
        }
    }
}
