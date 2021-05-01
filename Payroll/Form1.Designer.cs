namespace Payroll
{
    partial class frmMain
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHourlyRate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHoursWorked = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblGross = new System.Windows.Forms.Label();
            this.lblNet = new System.Windows.Forms.Label();
            this.lblSS = new System.Windows.Forms.Label();
            this.lblMed = new System.Windows.Forms.Label();
            this.lblStateTax = new System.Windows.Forms.Label();
            this.lblFedTax = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblEmpNumber = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(189, 58);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(176, 23);
            this.txtName.TabIndex = 0;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hourly Rate:";
            // 
            // txtHourlyRate
            // 
            this.txtHourlyRate.Location = new System.Drawing.Point(189, 87);
            this.txtHourlyRate.Name = "txtHourlyRate";
            this.txtHourlyRate.Size = new System.Drawing.Size(176, 23);
            this.txtHourlyRate.TabIndex = 1;
            this.txtHourlyRate.Text = "0";
            this.txtHourlyRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hours worked (pay period):";
            // 
            // txtHoursWorked
            // 
            this.txtHoursWorked.Location = new System.Drawing.Point(189, 116);
            this.txtHoursWorked.Name = "txtHoursWorked";
            this.txtHoursWorked.Size = new System.Drawing.Size(176, 23);
            this.txtHoursWorked.TabIndex = 2;
            this.txtHoursWorked.Text = "0";
            this.txtHoursWorked.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total SS Withheld:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(104, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Total Net Pay:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(94, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Total Gross Pay:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Total State Income Tax Withheld:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "Total Medicare Withheld:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 279);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 15);
            this.label9.TabIndex = 11;
            this.label9.Text = "Total Fed Income Tax Withheld:";
            // 
            // lblGross
            // 
            this.lblGross.BackColor = System.Drawing.SystemColors.Info;
            this.lblGross.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGross.Location = new System.Drawing.Point(189, 163);
            this.lblGross.Name = "lblGross";
            this.lblGross.Size = new System.Drawing.Size(176, 23);
            this.lblGross.TabIndex = 12;
            this.lblGross.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNet
            // 
            this.lblNet.BackColor = System.Drawing.SystemColors.Info;
            this.lblNet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNet.Location = new System.Drawing.Point(189, 303);
            this.lblNet.Name = "lblNet";
            this.lblNet.Size = new System.Drawing.Size(176, 23);
            this.lblNet.TabIndex = 13;
            this.lblNet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSS
            // 
            this.lblSS.BackColor = System.Drawing.SystemColors.Info;
            this.lblSS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSS.Location = new System.Drawing.Point(189, 191);
            this.lblSS.Name = "lblSS";
            this.lblSS.Size = new System.Drawing.Size(176, 23);
            this.lblSS.TabIndex = 14;
            this.lblSS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMed
            // 
            this.lblMed.BackColor = System.Drawing.SystemColors.Info;
            this.lblMed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMed.Location = new System.Drawing.Point(189, 219);
            this.lblMed.Name = "lblMed";
            this.lblMed.Size = new System.Drawing.Size(176, 23);
            this.lblMed.TabIndex = 15;
            this.lblMed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStateTax
            // 
            this.lblStateTax.BackColor = System.Drawing.SystemColors.Info;
            this.lblStateTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStateTax.Location = new System.Drawing.Point(189, 247);
            this.lblStateTax.Name = "lblStateTax";
            this.lblStateTax.Size = new System.Drawing.Size(176, 23);
            this.lblStateTax.TabIndex = 16;
            this.lblStateTax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFedTax
            // 
            this.lblFedTax.BackColor = System.Drawing.SystemColors.Info;
            this.lblFedTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFedTax.Location = new System.Drawing.Point(189, 275);
            this.lblFedTax.Name = "lblFedTax";
            this.lblFedTax.Size = new System.Drawing.Size(176, 23);
            this.lblFedTax.TabIndex = 17;
            this.lblFedTax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(284, 342);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "&Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(122, 342);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(363, 39);
            this.label10.TabIndex = 20;
            this.label10.Text = "Enter employee data; press \"Next\" to cycle to next employee and \"Submit\" to calcu" +
    "late";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(41, 342);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "&Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblEmpNumber
            // 
            this.lblEmpNumber.BackColor = System.Drawing.SystemColors.Info;
            this.lblEmpNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEmpNumber.Location = new System.Drawing.Point(15, 61);
            this.lblEmpNumber.Name = "lblEmpNumber";
            this.lblEmpNumber.Size = new System.Drawing.Size(88, 23);
            this.lblEmpNumber.TabIndex = 22;
            this.lblEmpNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOutput
            // 
            this.lblOutput.BackColor = System.Drawing.SystemColors.Info;
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutput.Location = new System.Drawing.Point(397, 9);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(673, 368);
            this.lblOutput.TabIndex = 23;
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(203, 342);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(75, 23);
            this.btnClearAll.TabIndex = 5;
            this.btnClearAll.Text = "Clear &All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 386);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblEmpNumber);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblFedTax);
            this.Controls.Add(this.lblStateTax);
            this.Controls.Add(this.lblMed);
            this.Controls.Add(this.lblSS);
            this.Controls.Add(this.lblNet);
            this.Controls.Add(this.lblGross);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHoursWorked);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHourlyRate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Griego Payroll Application";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHourlyRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHoursWorked;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblGross;
        private System.Windows.Forms.Label lblNet;
        private System.Windows.Forms.Label lblSS;
        private System.Windows.Forms.Label lblMed;
        private System.Windows.Forms.Label lblStateTax;
        private System.Windows.Forms.Label lblFedTax;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblEmpNumber;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnClearAll;
    }
}

