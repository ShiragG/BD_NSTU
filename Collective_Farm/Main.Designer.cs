namespace Collective_Farm
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.labelPlanHoz = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.labelDoc = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.butAuthoriz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPlanHoz
            // 
            this.labelPlanHoz.AutoSize = true;
            this.labelPlanHoz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelPlanHoz.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlanHoz.Location = new System.Drawing.Point(28, 53);
            this.labelPlanHoz.Name = "labelPlanHoz";
            this.labelPlanHoz.Size = new System.Drawing.Size(209, 21);
            this.labelPlanHoz.TabIndex = 0;
            this.labelPlanHoz.Text = "Планирование хозяйства";
            this.labelPlanHoz.Click += new System.EventHandler(this.labelPlanHoz_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(270, 53);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // labelDoc
            // 
            this.labelDoc.AutoSize = true;
            this.labelDoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelDoc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDoc.Location = new System.Drawing.Point(28, 89);
            this.labelDoc.Name = "labelDoc";
            this.labelDoc.Size = new System.Drawing.Size(126, 21);
            this.labelDoc.TabIndex = 2;
            this.labelDoc.Text = "Документация";
            this.labelDoc.Click += new System.EventHandler(this.labelDoc_Click);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelUser.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUser.Location = new System.Drawing.Point(28, 122);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(135, 21);
            this.labelUser.TabIndex = 4;
            this.labelUser.Text = "Учётная запись";
            this.labelUser.Click += new System.EventHandler(this.labelUser_Click);
            // 
            // butAuthoriz
            // 
            this.butAuthoriz.Image = global::Collective_Farm.Properties.Resources.Custom_Icon_Design_Flatastic_4_User_blue;
            this.butAuthoriz.Location = new System.Drawing.Point(475, 12);
            this.butAuthoriz.Name = "butAuthoriz";
            this.butAuthoriz.Size = new System.Drawing.Size(47, 49);
            this.butAuthoriz.TabIndex = 5;
            this.butAuthoriz.UseVisualStyleBackColor = true;
            this.butAuthoriz.Click += new System.EventHandler(this.butAuthoriz_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(534, 291);
            this.Controls.Add(this.butAuthoriz);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.labelDoc);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.labelPlanHoz);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(550, 330);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Фермерское хозяйство (пользовательское)";
         
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPlanHoz;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label labelDoc;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Button butAuthoriz;
    }
}

