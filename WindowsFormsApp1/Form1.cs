using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Switch_Click(object sender, EventArgs e)
        {
            (string, string, string) p = (btn1.Name, btn2.Name, btn3.Name);
            string cType = p;
            switch (cType)
            {
                case btn1:
                    
                    break;
                case btn2:
                    
                    break;
                case btn3:
                    
                    break;
                default:
                    break;
            }
        }
    }
}
