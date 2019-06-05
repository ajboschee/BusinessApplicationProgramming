namespace AJBFieldYields
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
            this.btnRun = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbOut
            // 
            this.rtbOut.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbOut.Location = new System.Drawing.Point(3, 50);
            this.rtbOut.Name = "rtbOut";
            this.rtbOut.Size = new System.Drawing.Size(544, 448);
            this.rtbOut.TabIndex = 0;
            this.rtbOut.Text = "";
            this.rtbOut.TextChanged += new System.EventHandler(this.rtbOut_TextChanged);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(100, 12);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(111, 32);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(327, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(111, 32);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 497);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.rtbOut);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbOut;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnExit;
    }
}

