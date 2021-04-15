namespace Collective_Farm
{
    partial class P_Sev
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(P_Sev));
            this.butAdd = new System.Windows.Forms.Button();
            this.butEdit = new System.Windows.Forms.Button();
            this.butDel = new System.Windows.Forms.Button();
            this.dGView = new System.Windows.Forms.DataGridView();
            this.butBack = new System.Windows.Forms.Button();
            this.butExData = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGView)).BeginInit();
            this.SuspendLayout();
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(709, 326);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(75, 23);
            this.butAdd.TabIndex = 7;
            this.butAdd.Text = "Добавить";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // butEdit
            // 
            this.butEdit.Location = new System.Drawing.Point(105, 326);
            this.butEdit.Name = "butEdit";
            this.butEdit.Size = new System.Drawing.Size(104, 23);
            this.butEdit.TabIndex = 6;
            this.butEdit.Text = "Редакитровать";
            this.butEdit.UseVisualStyleBackColor = true;
            this.butEdit.Click += new System.EventHandler(this.butEdit_Click);
            // 
            // butDel
            // 
            this.butDel.Location = new System.Drawing.Point(264, 326);
            this.butDel.Name = "butDel";
            this.butDel.Size = new System.Drawing.Size(75, 23);
            this.butDel.TabIndex = 5;
            this.butDel.Text = "Удалить";
            this.butDel.UseVisualStyleBackColor = true;
            this.butDel.Click += new System.EventHandler(this.butDel_Click);
            // 
            // dGView
            // 
            this.dGView.AllowUserToAddRows = false;
            this.dGView.AllowUserToDeleteRows = false;
            this.dGView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGView.Location = new System.Drawing.Point(8, 12);
            this.dGView.Name = "dGView";
            this.dGView.ReadOnly = true;
            this.dGView.Size = new System.Drawing.Size(780, 300);
            this.dGView.TabIndex = 4;
            this.dGView.SelectionChanged += new System.EventHandler(this.dGView_SelectionChanged);
            // 
            // butBack
            // 
            this.butBack.Location = new System.Drawing.Point(8, 326);
            this.butBack.Name = "butBack";
            this.butBack.Size = new System.Drawing.Size(75, 23);
            this.butBack.TabIndex = 9;
            this.butBack.Text = "Назад";
            this.butBack.UseVisualStyleBackColor = true;
            this.butBack.Click += new System.EventHandler(this.butBack_Click);
            // 
            // butExData
            // 
            this.butExData.Location = new System.Drawing.Point(406, 326);
            this.butExData.Name = "butExData";
            this.butExData.Size = new System.Drawing.Size(114, 23);
            this.butExData.TabIndex = 10;
            this.butExData.Text = "Вывести в файл";
            this.butExData.UseVisualStyleBackColor = true;
            this.butExData.Click += new System.EventHandler(this.butExData_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(563, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Граф. урож.";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // P_Sev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 361);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.butExData);
            this.Controls.Add(this.butBack);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.butEdit);
            this.Controls.Add(this.butDel);
            this.Controls.Add(this.dGView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(820, 400);
            this.Name = "P_Sev";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "План севооборота";
            ((System.ComponentModel.ISupportInitialize)(this.dGView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Button butEdit;
        private System.Windows.Forms.Button butDel;
        private System.Windows.Forms.DataGridView dGView;
        private System.Windows.Forms.Button butBack;
        private System.Windows.Forms.Button butExData;
        private System.Windows.Forms.Button button1;
    }
}