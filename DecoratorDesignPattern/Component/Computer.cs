using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern.Component
{
    public abstract class Computer
    {
       
        public abstract string Name { get;  }
        public abstract string Model { get; }
        public  string FullName { get { return Name + " " + Model; } }
        public  abstract double ComputePrice();
    }
}
