namespace Collective_Farm
{
    partial class Document
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Document));
            this.labelAvans = new System.Windows.Forms.Label();
            this.labelOrgan = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.labelDogov = new System.Windows.Forms.Label();
            this.butBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAvans
            // 
            this.labelAvans.AutoSize = true;
            this.labelAvans.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAvans.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAvans.Location = new System.Drawing.Point(12, 138);
            this.labelAvans.Name = "labelAvans";
            this.labelAvans.Size = new System.Drawing.Size(170, 21);
            this.labelAvans.TabIndex = 14;
            this.labelAvans.Text = "Авансовые платежи";
            this.labelAvans.Click += new System.EventHandler(this.labelAvans_Click);
            // 
            // labelOrgan
            // 
            this.labelOrgan.AutoSize = true;
            this.labelOrgan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelOrgan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOrgan.Location = new System.Drawing.Point(12, 103);
            this.labelOrgan.Name = "labelOrgan";
            this.labelOrgan.Size = new System.Drawing.Size(116, 21);
            this.labelOrgan.TabIndex = 13;
            this.labelOrgan.Text = "Организации";
            this.labelOrgan.Click += new System.EventHandler(this.labelOrgan_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(241, 68);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 12;
            // 
            // labelDogov
            // 
            this.labelDogov.AutoSize = true;
            this.labelDogov.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelDogov.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDogov.Location = new System.Drawing.Point(12, 68);
            this.labelDogov.Name = "labelDogov";
            this.labelDogov.Size = new System.Drawing.Size(88, 21);
            this.labelDogov.TabIndex = 11;
            this.labelDogov.Text = "Договора";
            this.labelDogov.Click += new System.EventHandler(this.labelDogov_Click);
            // 
            // butBack
            // 
            this.butBack.Location = new System.Drawing.Point(12, 12);
            this.butBack.Name = "butBack";
            this.butBack.Size = new System.Drawing.Size(36, 37);
            this.butBack.TabIndex = 15;
            this.butBack.Text = "<--";
            this.butBack.UseVisualStyleBackColor = true;
            this.butBack.Click += new System.EventHandler(this.butBack_Click);
            // 
            // Document
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 291);
            this.Controls.Add(this.butBack);
            this.Controls.Add(this.labelAvans);
            this.Controls.Add(this.labelOrgan);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.labelDogov);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(550, 330);
            this.Name = "Document";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Документация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelAvans;
        private System.Windows.Forms.Label labelOrgan;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label labelDogov;
        private System.Windows.Forms.Button butBack;
    }
}