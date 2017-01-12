using DecoratorDesignPattern.Component;
using DecoratorDesignPattern.ConcreteComponent;
using DecoratorDesignPattern.ConcreteDecorator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecoratorDesignPattern
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Computer lenovob560 = new LenovoB560();


            if (ram8GBOption.Checked)
            {
                lenovob560 = new Ram8GBDecorator(lenovob560);
            }
            else if (ram16GBOption.Checked)
            {
                lenovob560 = new Ram16GBDecorator(lenovob560);
            }
            else
            {
                lenovob560 = new Ram4GBDecorator(lenovob560);
            }

            mdlLbl.Text = lenovob560.FullName;
            priceLbl.Text = lenovob560.ComputePrice().ToString("C");
        }
    }
}
