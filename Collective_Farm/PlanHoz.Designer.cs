namespace Collective_Farm
{
    partial class PlanHoz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlanHoz));
            this.labelC = new System.Windows.Forms.Label();
            this.labelPSev = new System.Windows.Forms.Label();
            this.labelAutoP = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.labelGrWork = new System.Windows.Forms.Label();
            this.labelUch = new System.Windows.Forms.Label();
            this.butBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelC.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelC.Location = new System.Drawing.Point(12, 172);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(87, 21);
            this.labelC.TabIndex = 9;
            this.labelC.Text = "Культуры";
            this.labelC.Click += new System.EventHandler(this.labelC_Click);
            // 
            // labelPSev
            // 
            this.labelPSev.AutoSize = true;
            this.labelPSev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelPSev.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPSev.Location = new System.Drawing.Point(12, 137);
            this.labelPSev.Name = "labelPSev";
            this.labelPSev.Size = new System.Drawing.Size(157, 21);
            this.labelPSev.TabIndex = 8;
            this.labelPSev.Text = "План севооборота";
            this.labelPSev.Click += new System.EventHandler(this.labelPSev_Click);
            // 
            // labelAutoP
            // 
            this.labelAutoP.AutoSize = true;
            this.labelAutoP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAutoP.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAutoP.Location = new System.Drawing.Point(12, 102);
            this.labelAutoP.Name = "labelAutoP";
            this.labelAutoP.Size = new System.Drawing.Size(87, 21);
            this.labelAutoP.TabIndex = 7;
            this.labelAutoP.Text = "Автопарк";
            this.labelAutoP.Click += new System.EventHandler(this.labelAutoP_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(241, 67);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 6;
            // 
            // labelGrWork
            // 
            this.labelGrWork.AutoSize = true;
            this.labelGrWork.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelGrWork.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGrWork.Location = new System.Drawing.Point(12, 67);
            this.labelGrWork.Name = "labelGrWork";
            this.labelGrWork.Size = new System.Drawing.Size(120, 21);
            this.labelGrWork.TabIndex = 5;
            this.labelGrWork.Text = "График работ";
            this.labelGrWork.Click += new System.EventHandler(this.labelGrWork_Click);
            // 
            // labelUch
            // 
            this.labelUch.AutoSize = true;
            this.labelUch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelUch.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUch.Location = new System.Drawing.Point(12, 207);
            this.labelUch.Name = "labelUch";
            this.labelUch.Size = new System.Drawing.Size(77, 21);
            this.labelUch.TabIndex = 10;
            this.labelUch.Text = "Участки";
            this.labelUch.Click += new System.EventHandler(this.labelUch_Click);
            // 
            // butBack
            // 
            this.butBack.Location = new System.Drawing.Point(12, 12);
            this.butBack.Name = "butBack";
            this.butBack.Size = new System.Drawing.Size(40, 40);
            this.butBack.TabIndex = 11;
            this.butBack.Text = "<--";
            this.butBack.UseVisualStyleBackColor = true;
            this.butBack.Click += new System.EventHandler(this.butBack_Click);
            // 
            // PlanHoz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 291);
            this.Controls.Add(this.butBack);
            this.Controls.Add(this.labelUch);
            this.Controls.Add(this.labelC);
            this.Controls.Add(this.labelPSev);
            this.Controls.Add(this.labelAutoP);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.labelGrWork);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(550, 330);
            this.Name = "PlanHoz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Планирование хозяйства";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Label labelPSev;
        private System.Windows.Forms.Label labelAutoP;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label labelGrWork;
        private System.Windows.Forms.Label labelUch;
        private System.Windows.Forms.Button butBack;
    }
}