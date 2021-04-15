namespace Collective_Farm
{
    partial class User_Data
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Data));
            this.label1 = new System.Windows.Forms.Label();
            this.labelFirstN = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelSecondN = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelPartNim = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textOldPas = new System.Windows.Forms.TextBox();
            this.textNewPas = new System.Windows.Forms.TextBox();
            this.butCancel = new System.Windows.Forms.Button();
            this.butChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия";
            // 
            // labelFirstN
            // 
            this.labelFirstN.AutoSize = true;
            this.labelFirstN.Location = new System.Drawing.Point(36, 30);
            this.labelFirstN.Name = "labelFirstN";
            this.labelFirstN.Size = new System.Drawing.Size(0, 13);
            this.labelFirstN.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Имя";
            // 
            // labelSecondN
            // 
            this.labelSecondN.AutoSize = true;
            this.labelSecondN.Location = new System.Drawing.Point(36, 80);
            this.labelSecondN.Name = "labelSecondN";
            this.labelSecondN.Size = new System.Drawing.Size(0, 13);
            this.labelSecondN.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Отчество";
            // 
            // labelPartNim
            // 
            this.labelPartNim.AutoSize = true;
            this.labelPartNim.Location = new System.Drawing.Point(36, 137);
            this.labelPartNim.Name = "labelPartNim";
            this.labelPartNim.Size = new System.Drawing.Size(0, 13);
            this.labelPartNim.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(176, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Логин";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(176, 30);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(0, 13);
            this.labelLogin.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(291, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Старый пароль";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(291, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Новый пароль";
            // 
            // textOldPas
            // 
            this.textOldPas.Location = new System.Drawing.Point(291, 27);
            this.textOldPas.Name = "textOldPas";
            this.textOldPas.PasswordChar = '*';
            this.textOldPas.Size = new System.Drawing.Size(153, 20);
            this.textOldPas.TabIndex = 12;
            // 
            // textNewPas
            // 
            this.textNewPas.Location = new System.Drawing.Point(291, 78);
            this.textNewPas.Name = "textNewPas";
            this.textNewPas.PasswordChar = '*';
            this.textNewPas.Size = new System.Drawing.Size(153, 20);
            this.textNewPas.TabIndex = 13;
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(36, 176);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(75, 23);
            this.butCancel.TabIndex = 14;
            this.butCancel.Text = "Назад";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // butChange
            // 
            this.butChange.Location = new System.Drawing.Point(370, 175);
            this.butChange.Name = "butChange";
            this.butChange.Size = new System.Drawing.Size(75, 23);
            this.butChange.TabIndex = 15;
            this.butChange.Text = "Изменить";
            this.butChange.UseVisualStyleBackColor = true;
            this.butChange.Click += new System.EventHandler(this.butChange_Click);
            // 
            // User_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 210);
            this.Controls.Add(this.butChange);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.textNewPas);
            this.Controls.Add(this.textOldPas);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelPartNim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelSecondN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelFirstN);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "User_Data";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Пользовательские данные";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFirstN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelSecondN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelPartNim;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textOldPas;
        private System.Windows.Forms.TextBox textNewPas;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Button butChange;
    }
}