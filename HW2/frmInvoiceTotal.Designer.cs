
using System;

namespace FirstProject
{
    partial class frmInvoiceTotal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtDiscountPercent = new System.Windows.Forms.TextBox();
            this.txtDiscountAmount = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblDiscountTotal = new System.Windows.Forms.Label();
            this.txtDiscountTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtInvoiceTotal = new System.Windows.Forms.TextBox();
            this.txtnumofInvoices = new System.Windows.Forms.TextBox();
            this.cBoxCustomerType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(51, 225);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(87, 26);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(298, 225);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(82, 27);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Discount Amount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "&Subtotal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Total:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Discount Percent:";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(130, 55);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(101, 20);
            this.txtSubtotal.TabIndex = 1;
            this.txtSubtotal.TextChanged += new System.EventHandler(this.txtSubtotal_TextChanged);
            this.txtSubtotal.MouseHover += new System.EventHandler(this.txtSubtotal_TextChanged);
            // 
            // txtDiscountPercent
            // 
            this.txtDiscountPercent.Location = new System.Drawing.Point(129, 90);
            this.txtDiscountPercent.Name = "txtDiscountPercent";
            this.txtDiscountPercent.ReadOnly = true;
            this.txtDiscountPercent.Size = new System.Drawing.Size(102, 20);
            this.txtDiscountPercent.TabIndex = 8;
            this.txtDiscountPercent.TabStop = false;
            // 
            // txtDiscountAmount
            // 
            this.txtDiscountAmount.Location = new System.Drawing.Point(130, 131);
            this.txtDiscountAmount.Name = "txtDiscountAmount";
            this.txtDiscountAmount.ReadOnly = true;
            this.txtDiscountAmount.Size = new System.Drawing.Size(102, 20);
            this.txtDiscountAmount.TabIndex = 9;
            this.txtDiscountAmount.TabStop = false;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(129, 166);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(101, 20);
            this.txtTotal.TabIndex = 10;
            this.txtTotal.TabStop = false;
            // 
            // lblDiscountTotal
            // 
            this.lblDiscountTotal.AutoSize = true;
            this.lblDiscountTotal.Location = new System.Drawing.Point(258, 19);
            this.lblDiscountTotal.Name = "lblDiscountTotal";
            this.lblDiscountTotal.Size = new System.Drawing.Size(79, 13);
            this.lblDiscountTotal.TabIndex = 11;
            this.lblDiscountTotal.Text = "Discount Total:";
            // 
            // txtDiscountTotal
            // 
            this.txtDiscountTotal.Location = new System.Drawing.Point(354, 16);
            this.txtDiscountTotal.Name = "txtDiscountTotal";
            this.txtDiscountTotal.ReadOnly = true;
            this.txtDiscountTotal.Size = new System.Drawing.Size(80, 20);
            this.txtDiscountTotal.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Customer Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(258, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Invoices Total:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(258, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Number of Invoices:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(168, 227);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(93, 23);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtInvoiceTotal
            // 
            this.txtInvoiceTotal.Location = new System.Drawing.Point(349, 54);
            this.txtInvoiceTotal.Name = "txtInvoiceTotal";
            this.txtInvoiceTotal.ReadOnly = true;
            this.txtInvoiceTotal.Size = new System.Drawing.Size(84, 20);
            this.txtInvoiceTotal.TabIndex = 18;
            // 
            // txtnumofInvoices
            // 
            this.txtnumofInvoices.Location = new System.Drawing.Point(365, 87);
            this.txtnumofInvoices.Name = "txtnumofInvoices";
            this.txtnumofInvoices.ReadOnly = true;
            this.txtnumofInvoices.Size = new System.Drawing.Size(68, 20);
            this.txtnumofInvoices.TabIndex = 19;
            // 
            // cBoxCustomerType
            // 
            this.cBoxCustomerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxCustomerType.FormattingEnabled = true;
            this.cBoxCustomerType.Items.AddRange(new object[] {
            "R",
            "C",
            "T"});
            this.cBoxCustomerType.Location = new System.Drawing.Point(133, 17);
            this.cBoxCustomerType.Name = "cBoxCustomerType";
            this.cBoxCustomerType.Size = new System.Drawing.Size(66, 21);
            this.cBoxCustomerType.TabIndex = 20;
            // 
            // frmInvoiceTotal
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(462, 281);
            this.Controls.Add(this.cBoxCustomerType);
            this.Controls.Add(this.txtnumofInvoices);
            this.Controls.Add(this.txtInvoiceTotal);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDiscountTotal);
            this.Controls.Add(this.lblDiscountTotal);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtDiscountAmount);
            this.Controls.Add(this.txtDiscountPercent);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Name = "frmInvoiceTotal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice Total";
            this.DoubleClick += new System.EventHandler(this.btnClear_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtDiscountPercent;
        private System.Windows.Forms.TextBox txtDiscountAmount;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblDiscountTotal;
        private System.Windows.Forms.TextBox txtDiscountTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtInvoiceTotal;
        private System.Windows.Forms.TextBox txtnumofInvoices;
        private System.Windows.Forms.ComboBox cBoxCustomerType;
    }
}

