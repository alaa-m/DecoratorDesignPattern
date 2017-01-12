using DecoratorDesignPattern.Decotrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorDesignPattern.Component;

namespace DecoratorDesignPattern.ConcreteDecorator
{
    public class Ram16GBDecorator : BaseDecorator
    {

        public Ram16GBDecorator(Computer computer) : base(computer)
        {
        }

        public override string Model
        {
            get
            {
                return base.Model + " 16GB RAM" ;
            }
        }


        public override double ComputePrice()
        {
            return 79.0 + base.ComputePrice();
        }
    }
}
