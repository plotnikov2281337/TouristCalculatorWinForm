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
    public partial class GetDepartureCity : Form
    {
        public GetDepartureCity()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalculateFunction calculate = new CalculateFunction();
            CalculateFunction.db.initial();
            CalculateFunction.departureCity = CalculateFunction.getCity(textBox1.Text, this, new GetCityToVisit());
        }
    }
}
