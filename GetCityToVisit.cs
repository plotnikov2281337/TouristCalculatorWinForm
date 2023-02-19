using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TouristCalculatorWinForm.Data;

namespace TouristCalculatorWinForm
{
    public partial class GetCityToVisit : Form
    {
        public GetCityToVisit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalculateFunction calculate = new CalculateFunction();
            CalculateFunction.addCity(textBox1.Text, this, new GetCityToVisit());
        }
    }
}
