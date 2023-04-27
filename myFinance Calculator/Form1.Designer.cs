
namespace Financial_Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtbx_invest_amount = new System.Windows.Forms.TextBox();
            this.txtbx_invest_term = new System.Windows.Forms.TextBox();
            this.txtbx_int_rate = new System.Windows.Forms.TextBox();
            this.btn_calc_interest = new System.Windows.Forms.Button();
            this.lbl_result = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rdobtn_int_daily = new System.Windows.Forms.RadioButton();
            this.rdobtn_int_weekly = new System.Windows.Forms.RadioButton();
            this.rdobtn_monthly = new System.Windows.Forms.RadioButton();
            this.rdobtn_annually = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_tax = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabpg_compound_interest = new System.Windows.Forms.TabPage();
            this.tabpg_investment_aer = new System.Windows.Forms.TabPage();
            this.lbl_invest_return = new System.Windows.Forms.Label();
            this.btn_calc_invest_rtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtbx_invest_timespan = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbx_value_now = new System.Windows.Forms.TextBox();
            this.txtbx_initial_investment = new System.Windows.Forms.TextBox();
            this.tab_gross_tab = new System.Windows.Forms.TabPage();
            this.lbl_gross_to_aer = new System.Windows.Forms.Label();
            this.txtbx_times_per_year = new System.Windows.Forms.TextBox();
            this.txtbx_gross_int_rate = new System.Windows.Forms.TextBox();
            this.btn_calculate_gross_to_aer = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tab_loan_repayments = new System.Windows.Forms.TabPage();
            this.lbl_monthly_repayments = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtbx_timespan = new System.Windows.Forms.TextBox();
            this.txtbx_interest_rate = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtbx_loan_amount = new System.Windows.Forms.TextBox();
            this.btn_calc_loan = new System.Windows.Forms.Button();
            this.tab_mortgage_repayments = new System.Windows.Forms.TabPage();
            this.lbl_mortgage_amount = new System.Windows.Forms.Label();
            this.btn_mortgage_repayments = new System.Windows.Forms.Button();
            this.txtbx_amount_of_mortgage = new System.Windows.Forms.TextBox();
            this.txtbx_mortgage_downpayment = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtbx_mortgage_interest = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtbx_mortgage_timespan = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.lbl_mortgage_repayments = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.rdobtn_years = new System.Windows.Forms.RadioButton();
            this.rdobtn_months = new System.Windows.Forms.RadioButton();
            this.lbl_total_repaid = new System.Windows.Forms.Label();
            this.lbl_total_interest = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabpg_compound_interest.SuspendLayout();
            this.tabpg_investment_aer.SuspendLayout();
            this.tab_gross_tab.SuspendLayout();
            this.tab_loan_repayments.SuspendLayout();
            this.tab_mortgage_repayments.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbx_invest_amount
            // 
            this.txtbx_invest_amount.Location = new System.Drawing.Point(249, 17);
            this.txtbx_invest_amount.Name = "txtbx_invest_amount";
            this.txtbx_invest_amount.Size = new System.Drawing.Size(230, 26);
            this.txtbx_invest_amount.TabIndex = 0;
            // 
            // txtbx_invest_term
            // 
            this.txtbx_invest_term.Location = new System.Drawing.Point(249, 213);
            this.txtbx_invest_term.Name = "txtbx_invest_term";
            this.txtbx_invest_term.Size = new System.Drawing.Size(230, 26);
            this.txtbx_invest_term.TabIndex = 2;
            // 
            // txtbx_int_rate
            // 
            this.txtbx_int_rate.Location = new System.Drawing.Point(249, 86);
            this.txtbx_int_rate.Name = "txtbx_int_rate";
            this.txtbx_int_rate.Size = new System.Drawing.Size(230, 26);
            this.txtbx_int_rate.TabIndex = 4;
            // 
            // btn_calc_interest
            // 
            this.btn_calc_interest.Location = new System.Drawing.Point(489, 306);
            this.btn_calc_interest.Name = "btn_calc_interest";
            this.btn_calc_interest.Size = new System.Drawing.Size(110, 38);
            this.btn_calc_interest.TabIndex = 5;
            this.btn_calc_interest.Text = "button1";
            this.btn_calc_interest.UseVisualStyleBackColor = true;
            this.btn_calc_interest.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(549, 511);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(55, 20);
            this.lbl_result.TabIndex = 6;
            this.lbl_result.Text = "Result";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Investment amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Interest Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Times per Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Interest Term";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(485, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Years";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(496, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "%";
            // 
            // rdobtn_int_daily
            // 
            this.rdobtn_int_daily.AutoSize = true;
            this.rdobtn_int_daily.Location = new System.Drawing.Point(4, 22);
            this.rdobtn_int_daily.Name = "rdobtn_int_daily";
            this.rdobtn_int_daily.Size = new System.Drawing.Size(68, 24);
            this.rdobtn_int_daily.TabIndex = 14;
            this.rdobtn_int_daily.Text = "Daily";
            this.rdobtn_int_daily.UseVisualStyleBackColor = true;
            // 
            // rdobtn_int_weekly
            // 
            this.rdobtn_int_weekly.AutoSize = true;
            this.rdobtn_int_weekly.Location = new System.Drawing.Point(78, 22);
            this.rdobtn_int_weekly.Name = "rdobtn_int_weekly";
            this.rdobtn_int_weekly.Size = new System.Drawing.Size(85, 24);
            this.rdobtn_int_weekly.TabIndex = 15;
            this.rdobtn_int_weekly.Text = "Weekly";
            this.rdobtn_int_weekly.UseVisualStyleBackColor = true;
            // 
            // rdobtn_monthly
            // 
            this.rdobtn_monthly.AutoSize = true;
            this.rdobtn_monthly.Checked = true;
            this.rdobtn_monthly.Location = new System.Drawing.Point(169, 22);
            this.rdobtn_monthly.Name = "rdobtn_monthly";
            this.rdobtn_monthly.Size = new System.Drawing.Size(89, 24);
            this.rdobtn_monthly.TabIndex = 16;
            this.rdobtn_monthly.TabStop = true;
            this.rdobtn_monthly.Text = "Monthly";
            this.rdobtn_monthly.UseVisualStyleBackColor = true;
            // 
            // rdobtn_annually
            // 
            this.rdobtn_annually.AutoSize = true;
            this.rdobtn_annually.Location = new System.Drawing.Point(264, 22);
            this.rdobtn_annually.Name = "rdobtn_annually";
            this.rdobtn_annually.Size = new System.Drawing.Size(94, 24);
            this.rdobtn_annually.TabIndex = 17;
            this.rdobtn_annually.Text = "Annually";
            this.rdobtn_annually.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdobtn_annually);
            this.groupBox1.Controls.Add(this.rdobtn_monthly);
            this.groupBox1.Controls.Add(this.rdobtn_int_weekly);
            this.groupBox1.Controls.Add(this.rdobtn_int_daily);
            this.groupBox1.Location = new System.Drawing.Point(249, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 61);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // lbl_tax
            // 
            this.lbl_tax.AutoSize = true;
            this.lbl_tax.Location = new System.Drawing.Point(18, 524);
            this.lbl_tax.Name = "lbl_tax";
            this.lbl_tax.Size = new System.Drawing.Size(34, 20);
            this.lbl_tax.TabIndex = 19;
            this.lbl_tax.Text = "Tax";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabpg_compound_interest);
            this.tabControl1.Controls.Add(this.tabpg_investment_aer);
            this.tabControl1.Controls.Add(this.tab_gross_tab);
            this.tabControl1.Controls.Add(this.tab_loan_repayments);
            this.tabControl1.Controls.Add(this.tab_mortgage_repayments);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(953, 670);
            this.tabControl1.TabIndex = 20;
            // 
            // tabpg_compound_interest
            // 
            this.tabpg_compound_interest.Controls.Add(this.txtbx_invest_amount);
            this.tabpg_compound_interest.Controls.Add(this.lbl_tax);
            this.tabpg_compound_interest.Controls.Add(this.txtbx_invest_term);
            this.tabpg_compound_interest.Controls.Add(this.groupBox1);
            this.tabpg_compound_interest.Controls.Add(this.txtbx_int_rate);
            this.tabpg_compound_interest.Controls.Add(this.label7);
            this.tabpg_compound_interest.Controls.Add(this.btn_calc_interest);
            this.tabpg_compound_interest.Controls.Add(this.label6);
            this.tabpg_compound_interest.Controls.Add(this.lbl_result);
            this.tabpg_compound_interest.Controls.Add(this.label4);
            this.tabpg_compound_interest.Controls.Add(this.label1);
            this.tabpg_compound_interest.Controls.Add(this.label3);
            this.tabpg_compound_interest.Controls.Add(this.label2);
            this.tabpg_compound_interest.Location = new System.Drawing.Point(4, 29);
            this.tabpg_compound_interest.Name = "tabpg_compound_interest";
            this.tabpg_compound_interest.Padding = new System.Windows.Forms.Padding(3);
            this.tabpg_compound_interest.Size = new System.Drawing.Size(945, 637);
            this.tabpg_compound_interest.TabIndex = 0;
            this.tabpg_compound_interest.Text = "Compound Interest";
            this.tabpg_compound_interest.UseVisualStyleBackColor = true;
            // 
            // tabpg_investment_aer
            // 
            this.tabpg_investment_aer.Controls.Add(this.lbl_invest_return);
            this.tabpg_investment_aer.Controls.Add(this.btn_calc_invest_rtn);
            this.tabpg_investment_aer.Controls.Add(this.label9);
            this.tabpg_investment_aer.Controls.Add(this.txtbx_invest_timespan);
            this.tabpg_investment_aer.Controls.Add(this.label8);
            this.tabpg_investment_aer.Controls.Add(this.label5);
            this.tabpg_investment_aer.Controls.Add(this.txtbx_value_now);
            this.tabpg_investment_aer.Controls.Add(this.txtbx_initial_investment);
            this.tabpg_investment_aer.Location = new System.Drawing.Point(4, 29);
            this.tabpg_investment_aer.Name = "tabpg_investment_aer";
            this.tabpg_investment_aer.Padding = new System.Windows.Forms.Padding(3);
            this.tabpg_investment_aer.Size = new System.Drawing.Size(945, 637);
            this.tabpg_investment_aer.TabIndex = 1;
            this.tabpg_investment_aer.Text = "Investment AER";
            this.tabpg_investment_aer.UseVisualStyleBackColor = true;
            // 
            // lbl_invest_return
            // 
            this.lbl_invest_return.AutoSize = true;
            this.lbl_invest_return.Location = new System.Drawing.Point(31, 229);
            this.lbl_invest_return.Name = "lbl_invest_return";
            this.lbl_invest_return.Size = new System.Drawing.Size(76, 20);
            this.lbl_invest_return.TabIndex = 8;
            this.lbl_invest_return.Text = "% Return";
            // 
            // btn_calc_invest_rtn
            // 
            this.btn_calc_invest_rtn.Location = new System.Drawing.Point(347, 286);
            this.btn_calc_invest_rtn.Name = "btn_calc_invest_rtn";
            this.btn_calc_invest_rtn.Size = new System.Drawing.Size(117, 39);
            this.btn_calc_invest_rtn.TabIndex = 7;
            this.btn_calc_invest_rtn.Text = "Calculate";
            this.btn_calc_invest_rtn.UseVisualStyleBackColor = true;
            this.btn_calc_invest_rtn.Click += new System.EventHandler(this.btn_calc_invest_rtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(188, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Number of years invested";
            // 
            // txtbx_invest_timespan
            // 
            this.txtbx_invest_timespan.Location = new System.Drawing.Point(234, 133);
            this.txtbx_invest_timespan.Name = "txtbx_invest_timespan";
            this.txtbx_invest_timespan.Size = new System.Drawing.Size(230, 26);
            this.txtbx_invest_timespan.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Value now";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Initial Inventment value";
            // 
            // txtbx_value_now
            // 
            this.txtbx_value_now.Location = new System.Drawing.Point(234, 69);
            this.txtbx_value_now.Name = "txtbx_value_now";
            this.txtbx_value_now.Size = new System.Drawing.Size(230, 26);
            this.txtbx_value_now.TabIndex = 2;
            // 
            // txtbx_initial_investment
            // 
            this.txtbx_initial_investment.Location = new System.Drawing.Point(234, 20);
            this.txtbx_initial_investment.Name = "txtbx_initial_investment";
            this.txtbx_initial_investment.Size = new System.Drawing.Size(230, 26);
            this.txtbx_initial_investment.TabIndex = 1;
            // 
            // tab_gross_tab
            // 
            this.tab_gross_tab.Controls.Add(this.lbl_gross_to_aer);
            this.tab_gross_tab.Controls.Add(this.txtbx_times_per_year);
            this.tab_gross_tab.Controls.Add(this.txtbx_gross_int_rate);
            this.tab_gross_tab.Controls.Add(this.btn_calculate_gross_to_aer);
            this.tab_gross_tab.Controls.Add(this.label11);
            this.tab_gross_tab.Controls.Add(this.label10);
            this.tab_gross_tab.Location = new System.Drawing.Point(4, 29);
            this.tab_gross_tab.Name = "tab_gross_tab";
            this.tab_gross_tab.Size = new System.Drawing.Size(945, 637);
            this.tab_gross_tab.TabIndex = 2;
            this.tab_gross_tab.Text = "Gross to AER";
            this.tab_gross_tab.UseVisualStyleBackColor = true;
            // 
            // lbl_gross_to_aer
            // 
            this.lbl_gross_to_aer.AutoSize = true;
            this.lbl_gross_to_aer.Location = new System.Drawing.Point(73, 185);
            this.lbl_gross_to_aer.Name = "lbl_gross_to_aer";
            this.lbl_gross_to_aer.Size = new System.Drawing.Size(104, 20);
            this.lbl_gross_to_aer.TabIndex = 5;
            this.lbl_gross_to_aer.Text = "GrossToAER";
            // 
            // txtbx_times_per_year
            // 
            this.txtbx_times_per_year.Location = new System.Drawing.Point(417, 72);
            this.txtbx_times_per_year.Name = "txtbx_times_per_year";
            this.txtbx_times_per_year.Size = new System.Drawing.Size(167, 26);
            this.txtbx_times_per_year.TabIndex = 4;
            // 
            // txtbx_gross_int_rate
            // 
            this.txtbx_gross_int_rate.Location = new System.Drawing.Point(417, 32);
            this.txtbx_gross_int_rate.Name = "txtbx_gross_int_rate";
            this.txtbx_gross_int_rate.Size = new System.Drawing.Size(167, 26);
            this.txtbx_gross_int_rate.TabIndex = 3;
            // 
            // btn_calculate_gross_to_aer
            // 
            this.btn_calculate_gross_to_aer.Location = new System.Drawing.Point(487, 185);
            this.btn_calculate_gross_to_aer.Name = "btn_calculate_gross_to_aer";
            this.btn_calculate_gross_to_aer.Size = new System.Drawing.Size(120, 38);
            this.btn_calculate_gross_to_aer.TabIndex = 2;
            this.btn_calculate_gross_to_aer.Text = "Calculate";
            this.btn_calculate_gross_to_aer.UseVisualStyleBackColor = true;
            this.btn_calculate_gross_to_aer.Click += new System.EventHandler(this.btn_calculate_gross_to_aer_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(50, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(287, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "How many times a year is interest paid?";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(50, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Gross Interest Rate";
            // 
            // tab_loan_repayments
            // 
            this.tab_loan_repayments.Controls.Add(this.lbl_monthly_repayments);
            this.tab_loan_repayments.Controls.Add(this.label14);
            this.tab_loan_repayments.Controls.Add(this.label13);
            this.tab_loan_repayments.Controls.Add(this.txtbx_timespan);
            this.tab_loan_repayments.Controls.Add(this.txtbx_interest_rate);
            this.tab_loan_repayments.Controls.Add(this.label12);
            this.tab_loan_repayments.Controls.Add(this.txtbx_loan_amount);
            this.tab_loan_repayments.Controls.Add(this.btn_calc_loan);
            this.tab_loan_repayments.Location = new System.Drawing.Point(4, 29);
            this.tab_loan_repayments.Name = "tab_loan_repayments";
            this.tab_loan_repayments.Size = new System.Drawing.Size(945, 637);
            this.tab_loan_repayments.TabIndex = 3;
            this.tab_loan_repayments.Text = "Loan Repayments";
            this.tab_loan_repayments.UseVisualStyleBackColor = true;
            // 
            // lbl_monthly_repayments
            // 
            this.lbl_monthly_repayments.AutoSize = true;
            this.lbl_monthly_repayments.Location = new System.Drawing.Point(70, 225);
            this.lbl_monthly_repayments.Name = "lbl_monthly_repayments";
            this.lbl_monthly_repayments.Size = new System.Drawing.Size(92, 20);
            this.lbl_monthly_repayments.TabIndex = 7;
            this.lbl_monthly_repayments.Text = "repayments";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(54, 117);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(145, 20);
            this.label14.TabIndex = 6;
            this.label14.Text = "Timespan (months)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(54, 85);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 20);
            this.label13.TabIndex = 5;
            this.label13.Text = "Interest rate %";
            // 
            // txtbx_timespan
            // 
            this.txtbx_timespan.Location = new System.Drawing.Point(262, 111);
            this.txtbx_timespan.Name = "txtbx_timespan";
            this.txtbx_timespan.Size = new System.Drawing.Size(224, 26);
            this.txtbx_timespan.TabIndex = 4;
            // 
            // txtbx_interest_rate
            // 
            this.txtbx_interest_rate.Location = new System.Drawing.Point(262, 79);
            this.txtbx_interest_rate.Name = "txtbx_interest_rate";
            this.txtbx_interest_rate.Size = new System.Drawing.Size(224, 26);
            this.txtbx_interest_rate.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(54, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 20);
            this.label12.TabIndex = 2;
            this.label12.Text = "Loan Amount";
            // 
            // txtbx_loan_amount
            // 
            this.txtbx_loan_amount.Location = new System.Drawing.Point(262, 47);
            this.txtbx_loan_amount.Name = "txtbx_loan_amount";
            this.txtbx_loan_amount.Size = new System.Drawing.Size(224, 26);
            this.txtbx_loan_amount.TabIndex = 1;
            // 
            // btn_calc_loan
            // 
            this.btn_calc_loan.Location = new System.Drawing.Point(455, 239);
            this.btn_calc_loan.Name = "btn_calc_loan";
            this.btn_calc_loan.Size = new System.Drawing.Size(158, 42);
            this.btn_calc_loan.TabIndex = 0;
            this.btn_calc_loan.Text = "Calculate Loan";
            this.btn_calc_loan.UseVisualStyleBackColor = true;
            this.btn_calc_loan.Click += new System.EventHandler(this.btn_calc_loan_Click);
            // 
            // tab_mortgage_repayments
            // 
            this.tab_mortgage_repayments.Controls.Add(this.label23);
            this.tab_mortgage_repayments.Controls.Add(this.label22);
            this.tab_mortgage_repayments.Controls.Add(this.label21);
            this.tab_mortgage_repayments.Controls.Add(this.lbl_total_interest);
            this.tab_mortgage_repayments.Controls.Add(this.lbl_total_repaid);
            this.tab_mortgage_repayments.Controls.Add(this.rdobtn_months);
            this.tab_mortgage_repayments.Controls.Add(this.rdobtn_years);
            this.tab_mortgage_repayments.Controls.Add(this.label15);
            this.tab_mortgage_repayments.Controls.Add(this.lbl_mortgage_repayments);
            this.tab_mortgage_repayments.Controls.Add(this.txtbx_mortgage_timespan);
            this.tab_mortgage_repayments.Controls.Add(this.label18);
            this.tab_mortgage_repayments.Controls.Add(this.txtbx_mortgage_interest);
            this.tab_mortgage_repayments.Controls.Add(this.label17);
            this.tab_mortgage_repayments.Controls.Add(this.txtbx_mortgage_downpayment);
            this.tab_mortgage_repayments.Controls.Add(this.label16);
            this.tab_mortgage_repayments.Controls.Add(this.txtbx_amount_of_mortgage);
            this.tab_mortgage_repayments.Controls.Add(this.btn_mortgage_repayments);
            this.tab_mortgage_repayments.Controls.Add(this.lbl_mortgage_amount);
            this.tab_mortgage_repayments.Location = new System.Drawing.Point(4, 29);
            this.tab_mortgage_repayments.Name = "tab_mortgage_repayments";
            this.tab_mortgage_repayments.Size = new System.Drawing.Size(945, 637);
            this.tab_mortgage_repayments.TabIndex = 4;
            this.tab_mortgage_repayments.Text = "Mortgage Repayments";
            this.tab_mortgage_repayments.UseVisualStyleBackColor = true;
            // 
            // lbl_mortgage_amount
            // 
            this.lbl_mortgage_amount.AutoSize = true;
            this.lbl_mortgage_amount.Location = new System.Drawing.Point(63, 66);
            this.lbl_mortgage_amount.Name = "lbl_mortgage_amount";
            this.lbl_mortgage_amount.Size = new System.Drawing.Size(117, 20);
            this.lbl_mortgage_amount.TabIndex = 0;
            this.lbl_mortgage_amount.Text = "Amount of loan";
            // 
            // btn_mortgage_repayments
            // 
            this.btn_mortgage_repayments.Location = new System.Drawing.Point(506, 226);
            this.btn_mortgage_repayments.Name = "btn_mortgage_repayments";
            this.btn_mortgage_repayments.Size = new System.Drawing.Size(113, 41);
            this.btn_mortgage_repayments.TabIndex = 1;
            this.btn_mortgage_repayments.Text = "Mortgage";
            this.btn_mortgage_repayments.UseVisualStyleBackColor = true;
            this.btn_mortgage_repayments.Click += new System.EventHandler(this.btn_mortgage_repayments_Click);
            // 
            // txtbx_amount_of_mortgage
            // 
            this.txtbx_amount_of_mortgage.Location = new System.Drawing.Point(208, 63);
            this.txtbx_amount_of_mortgage.Name = "txtbx_amount_of_mortgage";
            this.txtbx_amount_of_mortgage.Size = new System.Drawing.Size(190, 26);
            this.txtbx_amount_of_mortgage.TabIndex = 2;
            // 
            // txtbx_mortgage_downpayment
            // 
            this.txtbx_mortgage_downpayment.Location = new System.Drawing.Point(208, 95);
            this.txtbx_mortgage_downpayment.Name = "txtbx_mortgage_downpayment";
            this.txtbx_mortgage_downpayment.Size = new System.Drawing.Size(190, 26);
            this.txtbx_mortgage_downpayment.TabIndex = 4;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(63, 98);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 20);
            this.label16.TabIndex = 3;
            this.label16.Text = "Deposit";
            // 
            // txtbx_mortgage_interest
            // 
            this.txtbx_mortgage_interest.Location = new System.Drawing.Point(208, 127);
            this.txtbx_mortgage_interest.Name = "txtbx_mortgage_interest";
            this.txtbx_mortgage_interest.Size = new System.Drawing.Size(190, 26);
            this.txtbx_mortgage_interest.TabIndex = 6;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(63, 130);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(103, 20);
            this.label17.TabIndex = 5;
            this.label17.Text = "Interest Rate";
            // 
            // txtbx_mortgage_timespan
            // 
            this.txtbx_mortgage_timespan.Location = new System.Drawing.Point(208, 159);
            this.txtbx_mortgage_timespan.Name = "txtbx_mortgage_timespan";
            this.txtbx_mortgage_timespan.Size = new System.Drawing.Size(190, 26);
            this.txtbx_mortgage_timespan.TabIndex = 8;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(63, 162);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(117, 20);
            this.label18.TabIndex = 7;
            this.label18.Text = "Mortgage Term";
            // 
            // lbl_mortgage_repayments
            // 
            this.lbl_mortgage_repayments.AutoSize = true;
            this.lbl_mortgage_repayments.Location = new System.Drawing.Point(217, 228);
            this.lbl_mortgage_repayments.Name = "lbl_mortgage_repayments";
            this.lbl_mortgage_repayments.Size = new System.Drawing.Size(17, 20);
            this.lbl_mortgage_repayments.TabIndex = 9;
            this.lbl_mortgage_repayments.Text = "..";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(404, 130);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(23, 20);
            this.label15.TabIndex = 10;
            this.label15.Text = "%";
            // 
            // rdobtn_years
            // 
            this.rdobtn_years.AutoSize = true;
            this.rdobtn_years.Checked = true;
            this.rdobtn_years.Location = new System.Drawing.Point(404, 160);
            this.rdobtn_years.Name = "rdobtn_years";
            this.rdobtn_years.Size = new System.Drawing.Size(76, 24);
            this.rdobtn_years.TabIndex = 11;
            this.rdobtn_years.TabStop = true;
            this.rdobtn_years.Text = "Years";
            this.rdobtn_years.UseVisualStyleBackColor = true;
            // 
            // rdobtn_months
            // 
            this.rdobtn_months.AutoSize = true;
            this.rdobtn_months.Location = new System.Drawing.Point(486, 160);
            this.rdobtn_months.Name = "rdobtn_months";
            this.rdobtn_months.Size = new System.Drawing.Size(87, 24);
            this.rdobtn_months.TabIndex = 12;
            this.rdobtn_months.Text = "Months";
            this.rdobtn_months.UseVisualStyleBackColor = true;
            // 
            // lbl_total_repaid
            // 
            this.lbl_total_repaid.AutoSize = true;
            this.lbl_total_repaid.Location = new System.Drawing.Point(217, 268);
            this.lbl_total_repaid.Name = "lbl_total_repaid";
            this.lbl_total_repaid.Size = new System.Drawing.Size(17, 20);
            this.lbl_total_repaid.TabIndex = 13;
            this.lbl_total_repaid.Text = "..";
            // 
            // lbl_total_interest
            // 
            this.lbl_total_interest.AutoSize = true;
            this.lbl_total_interest.Location = new System.Drawing.Point(217, 314);
            this.lbl_total_interest.Name = "lbl_total_interest";
            this.lbl_total_interest.Size = new System.Drawing.Size(17, 20);
            this.lbl_total_interest.TabIndex = 14;
            this.lbl_total_interest.Text = "..";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(63, 228);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(151, 20);
            this.label21.TabIndex = 15;
            this.label21.Text = "Monthly repayments";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(63, 268);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(99, 20);
            this.label22.TabIndex = 16;
            this.label22.Text = "Total Repaid";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(63, 314);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(103, 20);
            this.label23.TabIndex = 17;
            this.label23.Text = "Total Interest";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 670);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "myFinance Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabpg_compound_interest.ResumeLayout(false);
            this.tabpg_compound_interest.PerformLayout();
            this.tabpg_investment_aer.ResumeLayout(false);
            this.tabpg_investment_aer.PerformLayout();
            this.tab_gross_tab.ResumeLayout(false);
            this.tab_gross_tab.PerformLayout();
            this.tab_loan_repayments.ResumeLayout(false);
            this.tab_loan_repayments.PerformLayout();
            this.tab_mortgage_repayments.ResumeLayout(false);
            this.tab_mortgage_repayments.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtbx_invest_amount;
        private System.Windows.Forms.TextBox txtbx_invest_term;
        private System.Windows.Forms.TextBox txtbx_int_rate;
        private System.Windows.Forms.Button btn_calc_interest;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rdobtn_int_daily;
        private System.Windows.Forms.RadioButton rdobtn_int_weekly;
        private System.Windows.Forms.RadioButton rdobtn_monthly;
        private System.Windows.Forms.RadioButton rdobtn_annually;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_tax;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabpg_compound_interest;
        private System.Windows.Forms.TabPage tabpg_investment_aer;
        private System.Windows.Forms.Label lbl_invest_return;
        private System.Windows.Forms.Button btn_calc_invest_rtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtbx_invest_timespan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbx_value_now;
        private System.Windows.Forms.TextBox txtbx_initial_investment;
        private System.Windows.Forms.TabPage tab_gross_tab;
        private System.Windows.Forms.TextBox txtbx_times_per_year;
        private System.Windows.Forms.TextBox txtbx_gross_int_rate;
        private System.Windows.Forms.Button btn_calculate_gross_to_aer;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_gross_to_aer;
        private System.Windows.Forms.TabPage tab_loan_repayments;
        private System.Windows.Forms.Label lbl_monthly_repayments;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtbx_timespan;
        private System.Windows.Forms.TextBox txtbx_interest_rate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtbx_loan_amount;
        private System.Windows.Forms.Button btn_calc_loan;
        private System.Windows.Forms.TabPage tab_mortgage_repayments;
        private System.Windows.Forms.Label lbl_mortgage_repayments;
        private System.Windows.Forms.TextBox txtbx_mortgage_timespan;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtbx_mortgage_interest;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtbx_mortgage_downpayment;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtbx_amount_of_mortgage;
        private System.Windows.Forms.Button btn_mortgage_repayments;
        private System.Windows.Forms.Label lbl_mortgage_amount;
        private System.Windows.Forms.RadioButton rdobtn_months;
        private System.Windows.Forms.RadioButton rdobtn_years;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lbl_total_interest;
        private System.Windows.Forms.Label lbl_total_repaid;
    }
}

