namespace Collective_Farm
{
    partial class P_Sev_T
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(P_Sev_T));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comBSit = new System.Windows.Forms.ComboBox();
            this.comBKult = new System.Windows.Forms.ComboBox();
            this.texBOjidUr = new System.Windows.Forms.TextBox();
            this.texBFactU = new System.Windows.Forms.TextBox();
            this.butOK = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.textBAge1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Участок";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Культура";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ожидаемый урожай";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Фактический урожай";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(214, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Год";
            // 
            // comBSit
            // 
            this.comBSit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBSit.FormattingEnabled = true;
            this.comBSit.Location = new System.Drawing.Point(29, 30);
            this.comBSit.Name = "comBSit";
            this.comBSit.Size = new System.Drawing.Size(166, 21);
            this.comBSit.TabIndex = 5;
            // 
            // comBKult
            // 
            this.comBKult.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBKult.FormattingEnabled = true;
            this.comBKult.Location = new System.Drawing.Point(29, 88);
            this.comBKult.Name = "comBKult";
            this.comBKult.Size = new System.Drawing.Size(166, 21);
            this.comBKult.TabIndex = 6;
            // 
            // texBOjidUr
            // 
            this.texBOjidUr.Location = new System.Drawing.Point(29, 147);
            this.texBOjidUr.Name = "texBOjidUr";
            this.texBOjidUr.Size = new System.Drawing.Size(166, 20);
            this.texBOjidUr.TabIndex = 7;
            // 
            // texBFactU
            // 
            this.texBFactU.Location = new System.Drawing.Point(29, 201);
            this.texBFactU.Name = "texBFactU";
            this.texBFactU.Size = new System.Drawing.Size(166, 20);
            this.texBFactU.TabIndex = 8;
            // 
            // butOK
            // 
            this.butOK.Location = new System.Drawing.Point(297, 251);
            this.butOK.Name = "butOK";
            this.butOK.Size = new System.Drawing.Size(75, 23);
            this.butOK.TabIndex = 10;
            this.butOK.Text = "Ок";
            this.butOK.UseVisualStyleBackColor = true;
            this.butOK.Click += new System.EventHandler(this.butOK_Click);
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(29, 251);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(75, 23);
            this.butCancel.TabIndex = 11;
            this.butCancel.Text = "Отмена";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // textBAge1
            // 
            this.textBAge1.Location = new System.Drawing.Point(217, 31);
            this.textBAge1.Name = "textBAge1";
            this.textBAge1.Size = new System.Drawing.Size(155, 20);
            this.textBAge1.TabIndex = 13;
            // 
            // P_Sev_T
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 288);
            this.Controls.Add(this.textBAge1);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butOK);
            this.Controls.Add(this.texBFactU);
            this.Controls.Add(this.texBOjidUr);
            this.Controls.Add(this.comBKult);
            this.Controls.Add(this.comBSit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "P_Sev_T";
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
        private System.Windows.Forms.ComboBox comBSit;
        private System.Windows.Forms.ComboBox comBKult;
        private System.Windows.Forms.TextBox texBOjidUr;
        private System.Windows.Forms.TextBox texBFactU;
        private System.Windows.Forms.Button butOK;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.TextBox textBAge1;
    }
}