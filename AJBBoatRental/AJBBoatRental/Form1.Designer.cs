namespace AJBBoatRental
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
            this.rtbOut = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radPontoon = new System.Windows.Forms.RadioButton();
            this.radTrawler = new System.Windows.Forms.RadioButton();
            this.radRowBoat = new System.Windows.Forms.RadioButton();
            this.radCanoe = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkNet = new System.Windows.Forms.CheckBox();
            this.chkSonar = new System.Windows.Forms.CheckBox();
            this.chkLifePreserver = new System.Windows.Forms.CheckBox();
            this.chkFishingGear = new System.Windows.Forms.CheckBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.nudDays = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClear = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDays)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbOut
            // 
            this.rtbOut.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbOut.Location = new System.Drawing.Point(0, 191);
            this.rtbOut.Name = "rtbOut";
            this.rtbOut.Size = new System.Drawing.Size(448, 214);
            this.rtbOut.TabIndex = 0;
            this.rtbOut.Text = "";
            this.rtbOut.TextChanged += new System.EventHandler(this.rtbOut_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radPontoon);
            this.groupBox1.Controls.Add(this.radTrawler);
            this.groupBox1.Controls.Add(this.radRowBoat);
            this.groupBox1.Controls.Add(this.radCanoe);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 154);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Boats";
            // 
            // radPontoon
            // 
            this.radPontoon.Location = new System.Drawing.Point(6, 115);
            this.radPontoon.Name = "radPontoon";
            this.radPontoon.Size = new System.Drawing.Size(142, 22);
            this.radPontoon.TabIndex = 9;
            this.radPontoon.Text = "Pontoon $85.00";
            this.radPontoon.UseVisualStyleBackColor = true;
            this.radPontoon.CheckedChanged += new System.EventHandler(this.radPontoon_CheckedChanged);
            // 
            // radTrawler
            // 
            this.radTrawler.Location = new System.Drawing.Point(6, 89);
            this.radTrawler.Name = "radTrawler";
            this.radTrawler.Size = new System.Drawing.Size(128, 20);
            this.radTrawler.TabIndex = 8;
            this.radTrawler.Text = "Trawler $45.00";
            this.radTrawler.UseVisualStyleBackColor = true;
            this.radTrawler.CheckedChanged += new System.EventHandler(this.radTrawler_CheckedChanged);
            // 
            // radRowBoat
            // 
            this.radRowBoat.Location = new System.Drawing.Point(6, 62);
            this.radRowBoat.Name = "radRowBoat";
            this.radRowBoat.Size = new System.Drawing.Size(142, 22);
            this.radRowBoat.TabIndex = 7;
            this.radRowBoat.Text = "Rowboat $24.00";
            this.radRowBoat.UseVisualStyleBackColor = true;
            this.radRowBoat.CheckedChanged += new System.EventHandler(this.radRowBoat_CheckedChanged);
            // 
            // radCanoe
            // 
            this.radCanoe.Checked = true;
            this.radCanoe.Location = new System.Drawing.Point(6, 35);
            this.radCanoe.Name = "radCanoe";
            this.radCanoe.Size = new System.Drawing.Size(128, 24);
            this.radCanoe.TabIndex = 6;
            this.radCanoe.TabStop = true;
            this.radCanoe.Text = "Canoe $29.00";
            this.radCanoe.UseVisualStyleBackColor = true;
            this.radCanoe.CheckedChanged += new System.EventHandler(this.radCanoe_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkNet);
            this.groupBox2.Controls.Add(this.chkSonar);
            this.groupBox2.Controls.Add(this.chkLifePreserver);
            this.groupBox2.Controls.Add(this.chkFishingGear);
            this.groupBox2.Location = new System.Drawing.Point(172, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(198, 154);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gear";
            // 
            // chkNet
            // 
            this.chkNet.Location = new System.Drawing.Point(6, 116);
            this.chkNet.Name = "chkNet";
            this.chkNet.Size = new System.Drawing.Size(95, 21);
            this.chkNet.TabIndex = 9;
            this.chkNet.Text = "Net $3.00";
            this.chkNet.UseVisualStyleBackColor = true;
            this.chkNet.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // chkSonar
            // 
            this.chkSonar.Location = new System.Drawing.Point(6, 90);
            this.chkSonar.Name = "chkSonar";
            this.chkSonar.Size = new System.Drawing.Size(153, 20);
            this.chkSonar.TabIndex = 8;
            this.chkSonar.Text = "Sonar $12.00";
            this.chkSonar.UseVisualStyleBackColor = true;
            this.chkSonar.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // chkLifePreserver
            // 
            this.chkLifePreserver.Location = new System.Drawing.Point(6, 63);
            this.chkLifePreserver.Name = "chkLifePreserver";
            this.chkLifePreserver.Size = new System.Drawing.Size(186, 21);
            this.chkLifePreserver.TabIndex = 7;
            this.chkLifePreserver.Text = "Life Preserver $2.00";
            this.chkLifePreserver.UseVisualStyleBackColor = true;
            this.chkLifePreserver.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // chkFishingGear
            // 
            this.chkFishingGear.Location = new System.Drawing.Point(6, 35);
            this.chkFishingGear.Name = "chkFishingGear";
            this.chkFishingGear.Size = new System.Drawing.Size(171, 24);
            this.chkFishingGear.TabIndex = 6;
            this.chkFishingGear.Text = "Fishing Gear $15.00";
            this.chkFishingGear.UseVisualStyleBackColor = true;
            this.chkFishingGear.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lblDate
            // 
            this.lblDate.Location = new System.Drawing.Point(376, 31);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(80, 23);
            this.lblDate.TabIndex = 3;
            // 
            // nudDays
            // 
            this.nudDays.Location = new System.Drawing.Point(379, 137);
            this.nudDays.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudDays.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDays.Name = "nudDays";
            this.nudDays.Size = new System.Drawing.Size(55, 22);
            this.nudDays.TabIndex = 4;
            this.nudDays.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDays.ValueChanged += new System.EventHandler(this.nudDays_ValueChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(376, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Days";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(448, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuClear,
            this.mnuExit});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(44, 24);
            this.toolStripMenuItem1.Text = "File";
            // 
            // mnuClear
            // 
            this.mnuClear.Name = "mnuClear";
            this.mnuClear.Size = new System.Drawing.Size(216, 26);
            this.mnuClear.Text = "Clear";
            this.mnuClear.Click += new System.EventHandler(this.mnuClear_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(118, 26);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 405);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudDays);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rtbOut);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Andrew";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudDays)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbOut;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radPontoon;
        private System.Windows.Forms.RadioButton radTrawler;
        private System.Windows.Forms.RadioButton radRowBoat;
        private System.Windows.Forms.RadioButton radCanoe;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkNet;
        private System.Windows.Forms.CheckBox chkSonar;
        private System.Windows.Forms.CheckBox chkLifePreserver;
        private System.Windows.Forms.CheckBox chkFishingGear;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.NumericUpDown nudDays;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuClear;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
    }
}

