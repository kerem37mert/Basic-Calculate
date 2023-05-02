using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculate
{
    public partial class Form1 : Form
    {

        public int number1;
        public int number2;
        public int result;

        public Form1()
        {
            InitializeComponent();
        }

        private void writeLabel(int result)
        {
            labelResult.Visible = true;
            labelResult.Text = result.ToString();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            result = number1 + number2;
            writeLabel(result);
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            result = number1 - number2;
            writeLabel(result);
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            result = number1 * number2;
            writeLabel(result);
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            result = number1 / number2;
            writeLabel(result);
        }

        private void textBoxNumber1_TextChanged(object sender, EventArgs e)
        {
            number1 = Convert.ToInt32(textBoxNumber1.Text);
        }

        private void textBoxNumber2_TextChanged(object sender, EventArgs e)
        {
            number2 = Convert.ToInt32(textBoxNumber2.Text);
        }
    }
}
