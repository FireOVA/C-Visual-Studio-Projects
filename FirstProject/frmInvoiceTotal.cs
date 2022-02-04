using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstProject
{
    public partial class frmInvoiceTotal : Form
    {
        decimal discountTotal = 0m;
        int numOfInvoices = 0;
        decimal invoicesTotal = 0m;
        

        public frmInvoiceTotal()
        {
            InitializeComponent();
        }

        

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            numOfInvoices += 1;
            txtnumofInvoices.Text = numOfInvoices.ToString();


            Decimal invoiceSubtotal = Convert.ToDecimal(txtSubtotal.Text);

            decimal discountPercent = 0m;

            string cType = cBoxCustomerType.Text;
            switch(cType)
            { 
                case "R":
                    discountPercent = .2m;
                    break;
                case "C":
                    discountPercent = .15m;
                    break;
                case "T":
                    discountPercent = .1m;
                    break;
                default:
                    break;
            }

            decimal discountAmount = invoiceSubtotal * discountPercent;
            decimal invoiceTotal = invoiceSubtotal - discountAmount;
            discountTotal += discountAmount;
            txtDiscountTotal.Text = discountTotal.ToString();

            int x = 1;

            int y = 2;

            Decimal d = x / y;

            txtDiscountPercent.Text =
                discountPercent.ToString("p1");
            txtDiscountAmount.Text =
                discountAmount.ToString("c");
            txtTotal.Text = invoiceTotal.ToString("c");

           
            txtSubtotal.Focus();


            invoicesTotal += invoiceTotal;

            txtInvoiceTotal.Text = invoicesTotal.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void btnClear_Click(object sender, EventArgs e)
        {
            cBoxCustomerType.Items.Clear();
            txtDiscountAmount.Clear();
            txtDiscountPercent.Clear();
            txtDiscountTotal.Clear();
            txtInvoiceTotal.Clear();
            txtnumofInvoices.Clear();
            txtSubtotal.Clear();
            txtTotal.Clear();
            numOfInvoices = 0;
            discountTotal = 0m;
            invoicesTotal = 0m;
            this.cBoxCustomerType.Items.AddRange(new object[] { "R", "C", "T"});
        }

        private void txtSubtotal_TextChanged(object sender, EventArgs e)
        {
            txtTotal.Clear();
            txtDiscountPercent.Clear();
            txtDiscountAmount.Clear();
        }
    }
}
