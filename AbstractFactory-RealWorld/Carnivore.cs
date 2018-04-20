using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryRealWorld
{
    /// <summary>
    /// The 'AbstractProductB' abstract class
    /// </summary>
    abstract class Carnivore
    {
        public abstract void Eat(Herbivore h);
    }
}
