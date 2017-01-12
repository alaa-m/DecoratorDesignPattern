using DecoratorDesignPattern.Decotrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorDesignPattern.Component;

namespace DecoratorDesignPattern.HDDDecorator
{
    public class HDD128SSDDecorator : BaseDecorator
    {
        public HDD128SSDDecorator(Computer computer) : base(computer)
        {
        }

        public override string Model
        {
            get
            {
                return base.Model + " 128GB HDD SSD";
            }
        }


        public override double ComputePrice()
        {
            return 199.0 + base.ComputePrice();
        }
    }
}
