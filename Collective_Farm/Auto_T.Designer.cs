namespace Collective_Farm
{
    partial class Auto_T
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Auto_T));
            this.butCancel = new System.Windows.Forms.Button();
            this.butOk = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.texBName = new System.Windows.Forms.TextBox();
            this.comBStatus = new System.Windows.Forms.ComboBox();
            this.dataBDataPosTex = new System.Windows.Forms.DateTimePicker();
            this.dataBDataSledTex = new System.Windows.Forms.DateTimePicker();
            this.dataBDataV = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(15, 206);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(75, 23);
            this.butCancel.TabIndex = 26;
            this.butCancel.Text = "Отмена";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // butOk
            // 
            this.butOk.Location = new System.Drawing.Point(292, 206);
            this.butOk.Name = "butOk";
            this.butOk.Size = new System.Drawing.Size(75, 23);
            this.butOk.TabIndex = 25;
            this.butOk.Text = "Ок";
            this.butOk.UseVisualStyleBackColor = true;
            this.butOk.Click += new System.EventHandler(this.butOk_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Дата следующего тех. обслуж.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Дата последнего тех. обслуж.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Состояние";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Дата выпуска";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Название";
            // 
            // texBName
            // 
            this.texBName.Location = new System.Drawing.Point(12, 30);
            this.texBName.Name = "texBName";
            this.texBName.Size = new System.Drawing.Size(170, 20);
            this.texBName.TabIndex = 27;
            // 
            // comBStatus
            // 
            this.comBStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBStatus.FormattingEnabled = true;
            this.comBStatus.Items.AddRange(new object[] {
            "исправна",
            "не исправна"});
            this.comBStatus.Location = new System.Drawing.Point(12, 123);
            this.comBStatus.Name = "comBStatus";
            this.comBStatus.Size = new System.Drawing.Size(170, 21);
            this.comBStatus.TabIndex = 29;
            // 
            // dataBDataPosTex
            // 
            this.dataBDataPosTex.Location = new System.Drawing.Point(219, 25);
            this.dataBDataPosTex.Name = "dataBDataPosTex";
            this.dataBDataPosTex.Size = new System.Drawing.Size(169, 20);
            this.dataBDataPosTex.TabIndex = 30;
            // 
            // dataBDataSledTex
            // 
            this.dataBDataSledTex.Location = new System.Drawing.Point(219, 79);
            this.dataBDataSledTex.Name = "dataBDataSledTex";
            this.dataBDataSledTex.Size = new System.Drawing.Size(169, 20);
            this.dataBDataSledTex.TabIndex = 31;
            // 
            // dataBDataV
            // 
            this.dataBDataV.Location = new System.Drawing.Point(12, 79);
            this.dataBDataV.Name = "dataBDataV";
            this.dataBDataV.Size = new System.Drawing.Size(169, 20);
            this.dataBDataV.TabIndex = 32;
            // 
            // Auto_T
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 258);
            this.Controls.Add(this.dataBDataV);
            this.Controls.Add(this.dataBDataSledTex);
            this.Controls.Add(this.dataBDataPosTex);
            this.Controls.Add(this.comBStatus);
            this.Controls.Add(this.texBName);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butOk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Auto_T";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Заполнение формы";

            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Button butOk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox texBName;
        private System.Windows.Forms.ComboBox comBStatus;
        private System.Windows.Forms.DateTimePicker dataBDataPosTex;
        private System.Windows.Forms.DateTimePicker dataBDataSledTex;
        private System.Windows.Forms.DateTimePicker dataBDataV;
    }
}