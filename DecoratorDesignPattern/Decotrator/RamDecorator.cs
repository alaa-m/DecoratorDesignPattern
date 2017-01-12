using DecoratorDesignPattern.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern.Decotrator
{
    public class BaseDecorator : Computer
    {
        protected Computer _computer;
        public  BaseDecorator (Computer computer)
        {
            _computer = computer;
        }
        public override string Model
        {
            get
            {
                return _computer.Model;
            }
        }

        public override string Name
        {
            get
            {
                return _computer.Name;
            }
        }

        public  override double ComputePrice()
        {
            return _computer.ComputePrice();
        }
    }
}
