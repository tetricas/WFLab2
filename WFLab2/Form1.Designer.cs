namespace WFLab2
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
            this.Out = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Out
            // 
            this.Out.AutoSize = true;
            this.Out.Location = new System.Drawing.Point(77, 47);
            this.Out.Name = "Out";
            this.Out.Size = new System.Drawing.Size(0, 17);
            this.Out.TabIndex = 0;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(289, 161);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(129, 36);
            this.Start.TabIndex = 1;
            this.Start.Text = "Start!";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 256);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Out);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Out;
        private System.Windows.Forms.Button Start;
    }
}

