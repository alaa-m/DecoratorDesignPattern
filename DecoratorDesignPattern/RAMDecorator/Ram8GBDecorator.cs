using DecoratorDesignPattern.Decotrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorDesignPattern.Component;

namespace DecoratorDesignPattern.ConcreteDecorator
{
    public class Ram8GBDecorator : BaseDecorator
    {

        public override string Model
        {
            get
            {
                return base.Model + " 8GB RAM";
            }
        }

        public Ram8GBDecorator(Computer computer) : base(computer)
        {
        }

        public override double ComputePrice()
        {
            return 49.0 + base.ComputePrice();
        }
    }
}
