using System;
using System.Collections.Generic;
using System.Text;

namespace _07122020.Models
{
    class Animal
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        protected string Type { get; set; }

        public string Sleep()
        {
            return "Yatiram";
        }

        public virtual void Attack()
        {
            Console.WriteLine("Dishlemek");
        }
    }





    class Cat : Animal
    {
        public string Meow()
        {
            return "Meow";
        }

        public override void Attack()
        {
            Console.WriteLine("Cirmaglamaq");
        }
    }

    class Dog : Animal
    {
        public string Bark() 
        {
            return "Hav";
        }
    }

    class WildDog : Dog
    { 
    
    }

    class HomeDog : Dog
    { 
    
    }
}
