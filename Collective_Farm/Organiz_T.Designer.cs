namespace Collective_Farm
{
    partial class Organiz_T
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Organiz_T));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comBCity = new System.Windows.Forms.ComboBox();
            this.comBBank = new System.Windows.Forms.ComboBox();
            this.texBName = new System.Windows.Forms.TextBox();
            this.texBUlica = new System.Windows.Forms.TextBox();
            this.texBHouse = new System.Windows.Forms.TextBox();
            this.butCancel = new System.Windows.Forms.Button();
            this.butOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименование";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Банк";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Город";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Дом";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(214, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Улица";
            // 
            // comBCity
            // 
            this.comBCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBCity.FormattingEnabled = true;
            this.comBCity.Location = new System.Drawing.Point(12, 112);
            this.comBCity.Name = "comBCity";
            this.comBCity.Size = new System.Drawing.Size(162, 21);
            this.comBCity.TabIndex = 5;
            // 
            // comBBank
            // 
            this.comBBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBBank.FormattingEnabled = true;
            this.comBBank.Location = new System.Drawing.Point(12, 65);
            this.comBBank.Name = "comBBank";
            this.comBBank.Size = new System.Drawing.Size(162, 21);
            this.comBBank.TabIndex = 6;
            // 
            // texBName
            // 
            this.texBName.Location = new System.Drawing.Point(12, 21);
            this.texBName.Name = "texBName";
            this.texBName.Size = new System.Drawing.Size(162, 20);
            this.texBName.TabIndex = 7;
            // 
            // texBUlica
            // 
            this.texBUlica.Location = new System.Drawing.Point(217, 25);
            this.texBUlica.Name = "texBUlica";
            this.texBUlica.Size = new System.Drawing.Size(197, 20);
            this.texBUlica.TabIndex = 8;
            // 
            // texBHouse
            // 
            this.texBHouse.Location = new System.Drawing.Point(217, 70);
            this.texBHouse.Name = "texBHouse";
            this.texBHouse.Size = new System.Drawing.Size(197, 20);
            this.texBHouse.TabIndex = 9;
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(12, 186);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(75, 23);
            this.butCancel.TabIndex = 10;
            this.butCancel.Text = "Отмена";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // butOk
            // 
            this.butOk.Location = new System.Drawing.Point(339, 186);
            this.butOk.Name = "butOk";
            this.butOk.Size = new System.Drawing.Size(75, 23);
            this.butOk.TabIndex = 11;
            this.butOk.Text = "Ок";
            this.butOk.UseVisualStyleBackColor = true;
            this.butOk.Click += new System.EventHandler(this.butOk_Click);
            // 
            // Organiz_T
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 229);
            this.Controls.Add(this.butOk);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.texBHouse);
            this.Controls.Add(this.texBUlica);
            this.Controls.Add(this.texBName);
            this.Controls.Add(this.comBBank);
            this.Controls.Add(this.comBCity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Organiz_T";
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
        private System.Windows.Forms.ComboBox comBCity;
        private System.Windows.Forms.ComboBox comBBank;
        private System.Windows.Forms.TextBox texBName;
        private System.Windows.Forms.TextBox texBUlica;
        private System.Windows.Forms.TextBox texBHouse;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Button butOk;
    }
}