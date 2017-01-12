using DecoratorDesignPattern.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern.ConcreteComponent
{
    public class LenovoB560 : Computer
    {
        public override string Model
        {
            get
            {
                return "B560";
            }

        }

        public override string Name
        {
            get
            {
                return "Lenovo";
            }

           
        }

        public override double ComputePrice()
        {
            return 499.0;
        }
    }
}
