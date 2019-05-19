namespace AJBCollegeExpenses
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
            this.rtbOut = new System.Windows.Forms.RichTextBox();
            this.btnWrite = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtPayee = new System.Windows.Forms.TextBox();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.nudMonth = new System.Windows.Forms.NumericUpDown();
            this.nudDate = new System.Windows.Forms.NumericUpDown();
            this.nudYear = new System.Windows.Forms.NumericUpDown();
            this.lstType = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbOut
            // 
            this.rtbOut.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbOut.Location = new System.Drawing.Point(3, 205);
            this.rtbOut.Name = "rtbOut";
            this.rtbOut.Size = new System.Drawing.Size(454, 109);
            this.rtbOut.TabIndex = 0;
            this.rtbOut.Text = "";
            this.rtbOut.TextChanged += new System.EventHandler(this.rtbOut_TextChanged);
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(378, 115);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(60, 32);
            this.btnWrite.TabIndex = 1;
            this.btnWrite.Text = "&Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(378, 153);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 32);
            this.button2.TabIndex = 2;
            this.button2.Text = "E&xit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(336, 38);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 22);
            this.txtAmount.TabIndex = 3;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(26, 163);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(140, 22);
            this.txtDescription.TabIndex = 4;
            // 
            // txtPayee
            // 
            this.txtPayee.Location = new System.Drawing.Point(26, 135);
            this.txtPayee.Name = "txtPayee";
            this.txtPayee.Size = new System.Drawing.Size(140, 22);
            this.txtPayee.TabIndex = 5;
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(26, 107);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(140, 22);
            this.txtItem.TabIndex = 6;
            // 
            // nudMonth
            // 
            this.nudMonth.Location = new System.Drawing.Point(26, 12);
            this.nudMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMonth.Name = "nudMonth";
            this.nudMonth.Size = new System.Drawing.Size(79, 22);
            this.nudMonth.TabIndex = 7;
            this.nudMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudDate
            // 
            this.nudDate.Location = new System.Drawing.Point(26, 40);
            this.nudDate.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nudDate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDate.Name = "nudDate";
            this.nudDate.Size = new System.Drawing.Size(79, 22);
            this.nudDate.TabIndex = 8;
            this.nudDate.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudYear
            // 
            this.nudYear.Location = new System.Drawing.Point(26, 68);
            this.nudYear.Maximum = new decimal(new int[] {
            2128,
            0,
            0,
            0});
            this.nudYear.Minimum = new decimal(new int[] {
            2018,
            0,
            0,
            0});
            this.nudYear.Name = "nudYear";
            this.nudYear.Size = new System.Drawing.Size(79, 22);
            this.nudYear.TabIndex = 9;
            this.nudYear.Value = new decimal(new int[] {
            2018,
            0,
            0,
            0});
            // 
            // lstType
            // 
            this.lstType.FormattingEnabled = true;
            this.lstType.ItemHeight = 16;
            this.lstType.Items.AddRange(new object[] {
            "College",
            "Food",
            "Housing",
            "Travel",
            "Medical",
            "Misc."});
            this.lstType.Location = new System.Drawing.Point(175, 12);
            this.lstType.Name = "lstType";
            this.lstType.Size = new System.Drawing.Size(120, 84);
            this.lstType.TabIndex = 10;
            this.lstType.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(111, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Month";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(111, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(111, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "Year";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(172, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Item";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(172, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Payee";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(172, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Description";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(334, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 27);
            this.label7.TabIndex = 17;
            this.label7.Text = "Amount";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 319);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstType);
            this.Controls.Add(this.nudYear);
            this.Controls.Add(this.nudDate);
            this.Controls.Add(this.nudMonth);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.txtPayee);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.rtbOut);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "College Expenses";
            ((System.ComponentModel.ISupportInitialize)(this.nudMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbOut;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtPayee;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.NumericUpDown nudMonth;
        private System.Windows.Forms.NumericUpDown nudDate;
        private System.Windows.Forms.NumericUpDown nudYear;
        private System.Windows.Forms.ListBox lstType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

