using DecoratorDesignPattern.Decotrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorDesignPattern.Component;

namespace DecoratorDesignPattern.HDDDecorator
{
    class HDD256SSDDecorator : BaseDecorator
    {
        public HDD256SSDDecorator(Computer computer) : base(computer)
        {
        }

        public override string Model
        {
            get
            {
                return base.Model + " 256GB HDD SSD";
            }
        }


        public override double ComputePrice()
        {
            return 349.0 + base.ComputePrice();
        }
    }
}
