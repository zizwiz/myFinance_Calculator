﻿using System;
using System.Reflection;
using System.Windows.Forms;
using Financial_Calculator.algorithims;
using myFinance_Calculator.algorithims;
using myFinance_Calculator.utils;

namespace Financial_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            lbl_result.Text = "";
            lbl_tax.Text = "";

            int interval = 1;
            
            if (rdobtn_int_daily.Checked)
            {
                if (DateTime.IsLeapYear(DateTime.Today.Year)) interval = 366;
                interval = 365;
            }
            else if (rdobtn_int_weekly.Checked)
            {
                interval = 52;
            }
            else if (rdobtn_monthly.Checked)
            {
                interval = 12;
            }


            var data = CompoundInterest.CompoundInterestCalc(double.Parse(txtbx_invest_amount.Text),
                double.Parse(txtbx_int_rate.Text) / 100, //div by 100 as percentage
                interval,
                double.Parse(txtbx_invest_term.Text)); //currency string.


            if (data.Item2) lbl_tax.Text = "PayingTax";

            lbl_result.Text = data.Item1.ToString("C");
        }

        private void btn_calc_invest_rtn_Click(object sender, EventArgs e)
        {
            lbl_invest_return.Text = "Percentage return = " +
                                     ROI.CalculateROIChange(float.Parse(txtbx_initial_investment.Text), float.Parse(txtbx_value_now.Text), double.Parse(txtbx_invest_timespan.Text) ).ToString("0.##")
                                     +"%";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text += " : v" + Assembly.GetExecutingAssembly().GetName().Version; // put in the version number
        }

        private void btn_calculate_gross_to_aer_Click(object sender, EventArgs e)
        {
            lbl_gross_to_aer.Text = GrossToAER.CalculateGrossToAER(float.Parse(txtbx_gross_int_rate.Text), int.Parse(txtbx_times_per_year.Text)).ToString("0.##");
        }

        private void btn_calc_loan_Click(object sender, EventArgs e)
        {
            lbl_monthly_repayments.Text = "£" + CalcLoanRepayments.CalculateMonthlyRepayments(Convert.ToDouble(txtbx_loan_amount.Text),
                Convert.ToDouble(txtbx_interest_rate.Text),
                Convert.ToDouble(txtbx_timespan.Text)).ToString("f2");
        }

        
    }
}
