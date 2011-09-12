namespace BackgroundWorker
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btoStart = new System.Windows.Forms.Button();
            this.btoCancel = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(12, 244);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(292, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // btoStart
            // 
            this.btoStart.Location = new System.Drawing.Point(12, 9);
            this.btoStart.Name = "btoStart";
            this.btoStart.Size = new System.Drawing.Size(168, 23);
            this.btoStart.TabIndex = 1;
            this.btoStart.Text = "Start work in background";
            this.btoStart.UseVisualStyleBackColor = true;
            this.btoStart.Click += new System.EventHandler(this.btoStart_Click);
            // 
            // btoCancel
            // 
            this.btoCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btoCancel.Location = new System.Drawing.Point(229, 10);
            this.btoCancel.Name = "btoCancel";
            this.btoCancel.Size = new System.Drawing.Size(75, 23);
            this.btoCancel.TabIndex = 2;
            this.btoCancel.Text = "Cancel";
            this.btoCancel.UseVisualStyleBackColor = true;
            this.btoCancel.Click += new System.EventHandler(this.btoCancel_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Location = new System.Drawing.Point(12, 41);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(292, 192);
            this.txtOutput.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 287);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btoCancel);
            this.Controls.Add(this.btoStart);
            this.Controls.Add(this.progressBar1);
            this.Name = "Form1";
            this.Text = "Background Worker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btoStart;
        private System.Windows.Forms.Button btoCancel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtOutput;
    }
}

