using DecoratorDesignPattern.Component;
using DecoratorDesignPattern.Decotrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern.ConcreteDecorator
{
    public class Ram4GBDecorator : BaseDecorator
    {

        public override string Model
        {
            get
            {
                return base.Model + " 4GB RAM";
            }
        }

        public Ram4GBDecorator(Computer computer) : base(computer)
        {
        }

        public override double ComputePrice()
        {
            return base.ComputePrice();
        }
    }
}
