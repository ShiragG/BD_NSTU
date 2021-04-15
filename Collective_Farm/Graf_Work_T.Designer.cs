namespace Collective_Farm
{
    partial class Graf_Work_T
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Graf_Work_T));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.texBoxNorma = new System.Windows.Forms.TextBox();
            this.comBoxTeh = new System.Windows.Forms.ComboBox();
            this.comBoxSit = new System.Windows.Forms.ComboBox();
            this.butOk = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.TimeNR = new System.Windows.Forms.DateTimePicker();
            this.TimeKR = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Техника";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Участок";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Норма";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Начало работы";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(198, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Окончание работы";
            // 
            // texBoxNorma
            // 
            this.texBoxNorma.Location = new System.Drawing.Point(12, 143);
            this.texBoxNorma.Name = "texBoxNorma";
            this.texBoxNorma.Size = new System.Drawing.Size(164, 20);
            this.texBoxNorma.TabIndex = 8;
            // 
            // comBoxTeh
            // 
            this.comBoxTeh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxTeh.FormattingEnabled = true;
            this.comBoxTeh.Location = new System.Drawing.Point(15, 33);
            this.comBoxTeh.Name = "comBoxTeh";
            this.comBoxTeh.Size = new System.Drawing.Size(161, 21);
            this.comBoxTeh.TabIndex = 11;
            // 
            // comBoxSit
            // 
            this.comBoxSit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxSit.FormattingEnabled = true;
            this.comBoxSit.Location = new System.Drawing.Point(15, 88);
            this.comBoxSit.Name = "comBoxSit";
            this.comBoxSit.Size = new System.Drawing.Size(161, 21);
            this.comBoxSit.TabIndex = 12;
            // 
            // butOk
            // 
            this.butOk.Location = new System.Drawing.Point(292, 206);
            this.butOk.Name = "butOk";
            this.butOk.Size = new System.Drawing.Size(75, 23);
            this.butOk.TabIndex = 13;
            this.butOk.Text = "Ок";
            this.butOk.UseVisualStyleBackColor = true;
            this.butOk.Click += new System.EventHandler(this.butOk_Click);
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(15, 206);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(75, 23);
            this.butCancel.TabIndex = 14;
            this.butCancel.Text = "Отмена";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // TimeNR
            // 
            this.TimeNR.CustomFormat = "";
            this.TimeNR.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimeNR.Location = new System.Drawing.Point(198, 33);
            this.TimeNR.Name = "TimeNR";
            this.TimeNR.ShowUpDown = true;
            this.TimeNR.Size = new System.Drawing.Size(169, 20);
            this.TimeNR.TabIndex = 15;
            this.TimeNR.Value = new System.DateTime(2019, 12, 28, 0, 0, 0, 0);
            // 
            // TimeKR
            // 
            this.TimeKR.CustomFormat = "";
            this.TimeKR.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimeKR.Location = new System.Drawing.Point(198, 89);
            this.TimeKR.Name = "TimeKR";
            this.TimeKR.ShowUpDown = true;
            this.TimeKR.Size = new System.Drawing.Size(169, 20);
            this.TimeKR.TabIndex = 16;
            this.TimeKR.Value = new System.DateTime(2019, 12, 28, 0, 0, 0, 0);
            // 
            // Graf_Work_T
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 250);
            this.Controls.Add(this.TimeKR);
            this.Controls.Add(this.TimeNR);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butOk);
            this.Controls.Add(this.comBoxSit);
            this.Controls.Add(this.comBoxTeh);
            this.Controls.Add(this.texBoxNorma);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Graf_Work_T";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Заполнение формы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox texBoxNorma;
        private System.Windows.Forms.ComboBox comBoxTeh;
        private System.Windows.Forms.ComboBox comBoxSit;
        private System.Windows.Forms.Button butOk;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.DateTimePicker TimeNR;
        private System.Windows.Forms.DateTimePicker TimeKR;
    }
}