namespace Interest_Calculator
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPeriods = new System.Windows.Forms.TextBox();
            this.txtInterest = new System.Windows.Forms.TextBox();
            this.txtPrincipal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtAmountEarned = new System.Windows.Forms.TextBox();
            this.txtInterestEarned = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoAnnually = new System.Windows.Forms.RadioButton();
            this.rdoSemiannually = new System.Windows.Forms.RadioButton();
            this.rdoQuarterly = new System.Windows.Forms.RadioButton();
            this.rdoMonthly = new System.Windows.Forms.RadioButton();
            this.btnCalculator = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPeriods);
            this.groupBox1.Controls.Add(this.txtInterest);
            this.groupBox1.Controls.Add(this.txtPrincipal);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(73, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 146);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Preparation";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(164, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Years";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(164, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Number of Preiods";
            // 
            // txtPeriods
            // 
            this.txtPeriods.Location = new System.Drawing.Point(106, 79);
            this.txtPeriods.Name = "txtPeriods";
            this.txtPeriods.Size = new System.Drawing.Size(52, 20);
            this.txtPeriods.TabIndex = 0;
            this.txtPeriods.Text = "1";
            this.txtPeriods.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtInterest
            // 
            this.txtInterest.Location = new System.Drawing.Point(106, 53);
            this.txtInterest.Name = "txtInterest";
            this.txtInterest.Size = new System.Drawing.Size(52, 20);
            this.txtInterest.TabIndex = 0;
            this.txtInterest.Text = "0.00";
            this.txtInterest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPrincipal
            // 
            this.txtPrincipal.Location = new System.Drawing.Point(106, 27);
            this.txtPrincipal.Name = "txtPrincipal";
            this.txtPrincipal.Size = new System.Drawing.Size(182, 20);
            this.txtPrincipal.TabIndex = 0;
            this.txtPrincipal.Tag = "0.00";
            this.txtPrincipal.Text = " 0.00";
            this.txtPrincipal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Interest";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Principal ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtAmountEarned);
            this.groupBox3.Controls.Add(this.txtInterestEarned);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(73, 181);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(606, 146);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Result";
            // 
            // txtAmountEarned
            // 
            this.txtAmountEarned.Location = new System.Drawing.Point(374, 72);
            this.txtAmountEarned.Name = "txtAmountEarned";
            this.txtAmountEarned.Size = new System.Drawing.Size(226, 20);
            this.txtAmountEarned.TabIndex = 4;
            this.txtAmountEarned.Text = "0.00";
            this.txtAmountEarned.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtInterestEarned
            // 
            this.txtInterestEarned.Location = new System.Drawing.Point(123, 73);
            this.txtInterestEarned.Name = "txtInterestEarned";
            this.txtInterestEarned.Size = new System.Drawing.Size(150, 20);
            this.txtInterestEarned.TabIndex = 3;
            this.txtInterestEarned.Text = "0.00";
            this.txtInterestEarned.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amount Earned ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Interest Earned ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoAnnually);
            this.groupBox2.Controls.Add(this.rdoSemiannually);
            this.groupBox2.Controls.Add(this.rdoQuarterly);
            this.groupBox2.Controls.Add(this.rdoMonthly);
            this.groupBox2.Location = new System.Drawing.Point(390, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(289, 148);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Compound Frequency ";
            // 
            // rdoAnnually
            // 
            this.rdoAnnually.AutoSize = true;
            this.rdoAnnually.Location = new System.Drawing.Point(11, 92);
            this.rdoAnnually.Name = "rdoAnnually";
            this.rdoAnnually.Size = new System.Drawing.Size(127, 17);
            this.rdoAnnually.TabIndex = 0;
            this.rdoAnnually.TabStop = true;
            this.rdoAnnually.Text = " Annually (12 Months)";
            this.rdoAnnually.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdoAnnually.UseVisualStyleBackColor = true;
            // 
            // rdoSemiannually
            // 
            this.rdoSemiannually.AutoSize = true;
            this.rdoSemiannually.Location = new System.Drawing.Point(11, 69);
            this.rdoSemiannually.Name = "rdoSemiannually";
            this.rdoSemiannually.Size = new System.Drawing.Size(140, 17);
            this.rdoSemiannually.TabIndex = 0;
            this.rdoSemiannually.TabStop = true;
            this.rdoSemiannually.Text = "Semiannually (4 Months)";
            this.rdoSemiannually.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdoSemiannually.UseVisualStyleBackColor = true;
            // 
            // rdoQuarterly
            // 
            this.rdoQuarterly.AutoSize = true;
            this.rdoQuarterly.Location = new System.Drawing.Point(11, 49);
            this.rdoQuarterly.Name = "rdoQuarterly";
            this.rdoQuarterly.Size = new System.Drawing.Size(123, 17);
            this.rdoQuarterly.TabIndex = 0;
            this.rdoQuarterly.TabStop = true;
            this.rdoQuarterly.Text = " Quarterly (2 Months)";
            this.rdoQuarterly.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdoQuarterly.UseVisualStyleBackColor = true;
            // 
            // rdoMonthly
            // 
            this.rdoMonthly.AutoSize = true;
            this.rdoMonthly.Location = new System.Drawing.Point(11, 26);
            this.rdoMonthly.Name = "rdoMonthly";
            this.rdoMonthly.Size = new System.Drawing.Size(110, 17);
            this.rdoMonthly.TabIndex = 0;
            this.rdoMonthly.TabStop = true;
            this.rdoMonthly.Text = "Monthly (1 Month)";
            this.rdoMonthly.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdoMonthly.UseVisualStyleBackColor = true;
            // 
            // btnCalculator
            // 
            this.btnCalculator.Location = new System.Drawing.Point(689, 69);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Size = new System.Drawing.Size(75, 23);
            this.btnCalculator.TabIndex = 5;
            this.btnCalculator.Text = "Calculate";
            this.btnCalculator.UseVisualStyleBackColor = true;
            this.btnCalculator.Click += new System.EventHandler(this.btnCalculator_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(689, 98);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 372);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCalculator);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Compound Interest";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPrincipal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalculator;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtPeriods;
        private System.Windows.Forms.TextBox txtInterest;
        private System.Windows.Forms.TextBox txtAmountEarned;
        private System.Windows.Forms.TextBox txtInterestEarned;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdoMonthly;
        private System.Windows.Forms.RadioButton rdoAnnually;
        private System.Windows.Forms.RadioButton rdoSemiannually;
        private System.Windows.Forms.RadioButton rdoQuarterly;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

