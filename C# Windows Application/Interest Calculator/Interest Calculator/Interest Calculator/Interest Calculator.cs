using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interest_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
     {
         {
          
			Close();
		}

        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            double Principal, AnnualRate, InterestEarned;

            double FutureValue, RatePerPeriod;

            int NumberOfPeriods, CompoundType;

            Principal = Double.Parse(txtPrincipal.Text);
            AnnualRate = Double.Parse(txtInterest.Text) / 100;
            if (rdoMonthly.Checked)
                CompoundType = 12;
            else if (rdoQuarterly.Checked)
                CompoundType = 4;
            else if (rdoSemiannually.Checked)
                CompoundType = 2;
            else
                CompoundType = 1;

            NumberOfPeriods = Int32.Parse(txtPeriods.Text);
            
            double i = AnnualRate / CompoundType;
			
            int n    = CompoundType * NumberOfPeriods;

			RatePerPeriod  = AnnualRate / NumberOfPeriods;
			FutureValue    = Principal * Math.Pow(1+i, n);
			InterestEarned = FutureValue - Principal;

			txtInterestEarned.Text = InterestEarned.ToString("C");
	        txtAmountEarned.Text   = FutureValue.ToString("C");
		}

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.SkyBlue;
        }


        }
    }

