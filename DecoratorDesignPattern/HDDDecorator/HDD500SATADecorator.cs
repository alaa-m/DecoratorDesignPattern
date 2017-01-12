using DecoratorDesignPattern.Decotrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorDesignPattern.Component;

namespace DecoratorDesignPattern.HDDDecorator
{
    public class HDD500SATADecorator : BaseDecorator
    {
        public HDD500SATADecorator(Computer computer) : base(computer)
        {
        }

        public override string Model
        {
            get
            {
                return base.Model + " 500GB HDD SATA";
            }
        }


        public override double ComputePrice()
        {
            return base.ComputePrice();
        }
    }
}
