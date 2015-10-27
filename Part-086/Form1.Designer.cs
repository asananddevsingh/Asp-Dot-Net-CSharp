namespace Part_086
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
            this.btnTimeConsumingWork = new System.Windows.Forms.Button();
            this.btnPrintNumbers = new System.Windows.Forms.Button();
            this.lstNumbers = new System.Windows.Forms.ListBox();
            this.lstNumbersByThreading = new System.Windows.Forms.ListBox();
            this.btnPrintNumbersByThreading = new System.Windows.Forms.Button();
            this.btnTimeConsumingWorByThreading = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTimeConsumingWork
            // 
            this.btnTimeConsumingWork.Location = new System.Drawing.Point(28, 25);
            this.btnTimeConsumingWork.Name = "btnTimeConsumingWork";
            this.btnTimeConsumingWork.Size = new System.Drawing.Size(223, 23);
            this.btnTimeConsumingWork.TabIndex = 0;
            this.btnTimeConsumingWork.Text = "Do time consuming work";
            this.btnTimeConsumingWork.UseVisualStyleBackColor = true;
            this.btnTimeConsumingWork.Click += new System.EventHandler(this.btnTimeConsumingWork_Click);
            // 
            // btnPrintNumbers
            // 
            this.btnPrintNumbers.Location = new System.Drawing.Point(61, 66);
            this.btnPrintNumbers.Name = "btnPrintNumbers";
            this.btnPrintNumbers.Size = new System.Drawing.Size(157, 23);
            this.btnPrintNumbers.TabIndex = 1;
            this.btnPrintNumbers.Text = "Print numbers";
            this.btnPrintNumbers.UseVisualStyleBackColor = true;
            this.btnPrintNumbers.Click += new System.EventHandler(this.btnPrintNumbers_Click);
            // 
            // lstNumbers
            // 
            this.lstNumbers.FormattingEnabled = true;
            this.lstNumbers.Location = new System.Drawing.Point(28, 119);
            this.lstNumbers.Name = "lstNumbers";
            this.lstNumbers.Size = new System.Drawing.Size(222, 238);
            this.lstNumbers.TabIndex = 2;
            // 
            // lstNumbersByThreading
            // 
            this.lstNumbersByThreading.FormattingEnabled = true;
            this.lstNumbersByThreading.Location = new System.Drawing.Point(364, 119);
            this.lstNumbersByThreading.Name = "lstNumbersByThreading";
            this.lstNumbersByThreading.Size = new System.Drawing.Size(222, 238);
            this.lstNumbersByThreading.TabIndex = 5;            
            // 
            // btnPrintNumbersByThreading
            // 
            this.btnPrintNumbersByThreading.Location = new System.Drawing.Point(397, 66);
            this.btnPrintNumbersByThreading.Name = "btnPrintNumbersByThreading";
            this.btnPrintNumbersByThreading.Size = new System.Drawing.Size(157, 23);
            this.btnPrintNumbersByThreading.TabIndex = 4;
            this.btnPrintNumbersByThreading.Text = "Print numbers by threading";
            this.btnPrintNumbersByThreading.UseVisualStyleBackColor = true;
            this.btnPrintNumbersByThreading.Click += new System.EventHandler(this.btnPrintNumbersByThreading_Click);
            // 
            // btnTimeConsumingWorByThreading
            // 
            this.btnTimeConsumingWorByThreading.Location = new System.Drawing.Point(364, 25);
            this.btnTimeConsumingWorByThreading.Name = "btnTimeConsumingWorByThreading";
            this.btnTimeConsumingWorByThreading.Size = new System.Drawing.Size(223, 23);
            this.btnTimeConsumingWorByThreading.TabIndex = 3;
            this.btnTimeConsumingWorByThreading.Text = "Do time consuming work by threading";
            this.btnTimeConsumingWorByThreading.UseVisualStyleBackColor = true;
            this.btnTimeConsumingWorByThreading.Click += new System.EventHandler(this.btnTimeConsumingWorByThreading_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 386);
            this.Controls.Add(this.lstNumbersByThreading);
            this.Controls.Add(this.btnPrintNumbersByThreading);
            this.Controls.Add(this.btnTimeConsumingWorByThreading);
            this.Controls.Add(this.lstNumbers);
            this.Controls.Add(this.btnPrintNumbers);
            this.Controls.Add(this.btnTimeConsumingWork);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTimeConsumingWork;
        private System.Windows.Forms.Button btnPrintNumbers;
        private System.Windows.Forms.ListBox lstNumbers;
        private System.Windows.Forms.ListBox lstNumbersByThreading;
        private System.Windows.Forms.Button btnPrintNumbersByThreading;
        private System.Windows.Forms.Button btnTimeConsumingWorByThreading;
    }
}

