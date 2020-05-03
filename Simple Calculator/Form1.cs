using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;

namespace Simple_Calculator
{
    public partial class Frm1 : Form
    {
        public Frm1()
        {
            InitializeComponent();
        } //Declare variables
        decimal operand1;
        decimal operand2;
        char operator1;
        decimal result;
        private void txtOperand1_TextChanged(object sender, EventArgs e)
        {
            operand1 = Convert.ToDecimal(txtOperand1.Text);
        }

        private void txtOperator1_TextChanged(object sender, EventArgs e)
        {
            operator1 = Convert.ToChar(txtOperator1.Text);
        }

        private void txtOperand2_TextChanged(object sender, EventArgs e)
        {
            operand2 = Convert.ToDecimal(txtOperand2.Text);
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            result = Calculate(operand1, operator1, operand2);
            txtResult.Text = result.ToString();
            txtOperand1.Focus();
        }



        private decimal Calculate(decimal operand1, char operator1, decimal operand2)
        { 
            result = 0;

            switch (operator1)
            {
                case '+':
                    result = (operand1 + operand2);
                    break;
                case '-':
                    result = (operand1 - operand2);
                    break;
                case '/':
                    result = (operand1 / operand2);
                    break;
                case '*':
                    result = (operand1 * operand2);
                    break;
            }
            return result;


        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
