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
    public partial class GetTripCost : Form
    {
        public GetTripCost()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalculateFunction calculate = new CalculateFunction();
            if (textBox1.Text == "")
            {
                MessageBox.Show("Введите сумму поездки!", "Провал", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                double tripCost;
                try
                {
                    double.TryParse(textBox1.Text, out tripCost);
                    CalculateFunction.tripCost = tripCost;
                    CalculateFunction.totalCost = CalculateFunction.calculateFunction();
                    if(CalculateFunction.tripCost >= CalculateFunction.totalCost)
                    {
                        MessageBox.Show($"Поездка стоит {CalculateFunction.totalCost}. Вам хватает средств.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } else
                    {
                        MessageBox.Show($"Поездка стоит {CalculateFunction.totalCost}. Вам не хватает средств.", "Провал", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    this.Close();
                } catch 
                {
                    MessageBox.Show($"Что то пошло не так, перепроверьте введённые вами данные.", "Провал", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
        }
    }
}
