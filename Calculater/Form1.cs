using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculater
{
    public partial class Form1 : Form
    {
        Double result = 0;
        String operation = "";
        bool is_op = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((txtresult.Text == "0") || (is_op))
                txtresult.Clear();

            is_op = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!txtresult.Text.Contains("."))
                    txtresult.Text = txtresult.Text + button.Text;
            }
            else
                txtresult.Text = txtresult.Text + button.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (result != 0)
            {
                btnequal.PerformClick();
                operation = button.Text;
                is_op = true;
            }
            else
            {

                operation = button.Text;
                result = Double.Parse(txtresult.Text);
                is_op = true;
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtresult.Text = "0";
            result = 0;
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    txtresult.Text = (result + Double.Parse(txtresult.Text)).ToString();
                    break;
                case "-":
                    txtresult.Text = (result - Double.Parse(txtresult.Text)).ToString();
                    break;
                case "*":
                    txtresult.Text = (result * Double.Parse(txtresult.Text)).ToString();
                    break;
                case "/":
                    txtresult.Text = (result / Double.Parse(txtresult.Text)).ToString();
                    break;
                default:
                    break;
            }
            result = Double.Parse(txtresult.Text);
        }   
    }
}
    

