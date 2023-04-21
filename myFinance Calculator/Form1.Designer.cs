
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
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabpg_compound_interest.SuspendLayout();
            this.tabpg_investment_aer.SuspendLayout();
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
    }
}

