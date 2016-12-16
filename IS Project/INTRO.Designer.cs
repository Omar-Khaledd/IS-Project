namespace IS_Project
{
    partial class INTRO
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(161, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "HireMe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Ivory;
            this.label2.Location = new System.Drawing.Point(301, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "The Leading Hiring Application";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.progressBar1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.progressBar1.ForeColor = System.Drawing.Color.Indigo;
            this.progressBar1.Location = new System.Drawing.Point(1, 205);
            this.progressBar1.Maximum = 50;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(547, 17);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 2;
            this.progressBar1.Value = 2;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 32;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // INTRO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(548, 319);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "INTRO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INTRO";
            this.Load += new System.EventHandler(this.INTRO_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer2;
    }
}