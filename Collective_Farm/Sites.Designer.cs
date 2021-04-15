namespace Collective_Farm
{
    partial class Sites
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sites));
            this.butAdd = new System.Windows.Forms.Button();
            this.butEdit = new System.Windows.Forms.Button();
            this.butDel = new System.Windows.Forms.Button();
            this.dGView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.texBNomer = new System.Windows.Forms.TextBox();
            this.texBPlosh = new System.Windows.Forms.TextBox();
            this.butBack = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comBStatus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGView)).BeginInit();
            this.SuspendLayout();
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(598, 166);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(75, 23);
            this.butAdd.TabIndex = 11;
            this.butAdd.Text = "Добавить";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // butEdit
            // 
            this.butEdit.Location = new System.Drawing.Point(470, 166);
            this.butEdit.Name = "butEdit";
            this.butEdit.Size = new System.Drawing.Size(93, 23);
            this.butEdit.TabIndex = 10;
            this.butEdit.Text = "Редакитровать";
            this.butEdit.UseVisualStyleBackColor = true;
            this.butEdit.Click += new System.EventHandler(this.butEdit_Click);
            // 
            // butDel
            // 
            this.butDel.Location = new System.Drawing.Point(204, 273);
            this.butDel.Name = "butDel";
            this.butDel.Size = new System.Drawing.Size(75, 23);
            this.butDel.TabIndex = 9;
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
            this.dGView.Size = new System.Drawing.Size(456, 249);
            this.dGView.TabIndex = 8;
            this.dGView.SelectionChanged += new System.EventHandler(this.dGView_SelectionChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(470, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Номер уастка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(470, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Площадь";
            // 
            // texBNomer
            // 
            this.texBNomer.Location = new System.Drawing.Point(471, 25);
            this.texBNomer.Name = "texBNomer";
            this.texBNomer.Size = new System.Drawing.Size(202, 20);
            this.texBNomer.TabIndex = 14;
            // 
            // texBPlosh
            // 
            this.texBPlosh.Location = new System.Drawing.Point(470, 80);
            this.texBPlosh.Name = "texBPlosh";
            this.texBPlosh.Size = new System.Drawing.Size(202, 20);
            this.texBPlosh.TabIndex = 15;
            // 
            // butBack
            // 
            this.butBack.Location = new System.Drawing.Point(8, 273);
            this.butBack.Name = "butBack";
            this.butBack.Size = new System.Drawing.Size(75, 23);
            this.butBack.TabIndex = 16;
            this.butBack.Text = "Назад";
            this.butBack.UseVisualStyleBackColor = true;
            this.butBack.Click += new System.EventHandler(this.butBack_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(469, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Состояние";
            // 
            // comBStatus
            // 
            this.comBStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBStatus.FormattingEnabled = true;
            this.comBStatus.Items.AddRange(new object[] {
            "готово к использованию",
            "под паром"});
            this.comBStatus.Location = new System.Drawing.Point(470, 123);
            this.comBStatus.Name = "comBStatus";
            this.comBStatus.Size = new System.Drawing.Size(202, 21);
            this.comBStatus.TabIndex = 19;
            // 
            // Sites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 312);
            this.Controls.Add(this.comBStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.butBack);
            this.Controls.Add(this.texBPlosh);
            this.Controls.Add(this.texBNomer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.butEdit);
            this.Controls.Add(this.butDel);
            this.Controls.Add(this.dGView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(693, 351);
            this.Name = "Sites";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sites";
            ((System.ComponentModel.ISupportInitialize)(this.dGView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Button butEdit;
        private System.Windows.Forms.Button butDel;
        private System.Windows.Forms.DataGridView dGView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox texBNomer;
        private System.Windows.Forms.TextBox texBPlosh;
        private System.Windows.Forms.Button butBack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comBStatus;
    }
}