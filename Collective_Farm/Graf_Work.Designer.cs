namespace Collective_Farm
{
    partial class Graf_Work
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Graf_Work));
            this.butEdit = new System.Windows.Forms.Button();
            this.butAdd = new System.Windows.Forms.Button();
            this.butDel = new System.Windows.Forms.Button();
            this.butBack = new System.Windows.Forms.Button();
            this.dGView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGView1)).BeginInit();
            this.SuspendLayout();
            // 
            // butEdit
            // 
            this.butEdit.Location = new System.Drawing.Point(413, 326);
            this.butEdit.Name = "butEdit";
            this.butEdit.Size = new System.Drawing.Size(104, 23);
            this.butEdit.TabIndex = 2;
            this.butEdit.Text = "Редакитровать";
            this.butEdit.UseVisualStyleBackColor = true;
            this.butEdit.Click += new System.EventHandler(this.butEdit_Click);
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(713, 326);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(75, 23);
            this.butAdd.TabIndex = 3;
            this.butAdd.Text = "Добавить";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // butDel
            // 
            this.butDel.Location = new System.Drawing.Point(236, 326);
            this.butDel.Name = "butDel";
            this.butDel.Size = new System.Drawing.Size(75, 23);
            this.butDel.TabIndex = 1;
            this.butDel.Text = "Удалить";
            this.butDel.UseVisualStyleBackColor = true;
            this.butDel.Click += new System.EventHandler(this.butDel_Click);
            // 
            // butBack
            // 
            this.butBack.Location = new System.Drawing.Point(12, 326);
            this.butBack.Name = "butBack";
            this.butBack.Size = new System.Drawing.Size(75, 23);
            this.butBack.TabIndex = 9;
            this.butBack.Text = "Назад";
            this.butBack.UseVisualStyleBackColor = true;
            this.butBack.Click += new System.EventHandler(this.butBack_Click);
            // 
            // dGView1
            // 
            this.dGView1.AllowUserToAddRows = false;
            this.dGView1.AllowUserToDeleteRows = false;
            this.dGView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGView1.Location = new System.Drawing.Point(12, 12);
            this.dGView1.Name = "dGView1";
            this.dGView1.ReadOnly = true;
            this.dGView1.Size = new System.Drawing.Size(776, 291);
            this.dGView1.TabIndex = 10;
            this.dGView1.SelectionChanged += new System.EventHandler(this.dGView1_SelectionChanged_1);
            // 
            // Graf_Work
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 361);
            this.Controls.Add(this.dGView1);
            this.Controls.Add(this.butBack);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.butDel);
            this.Controls.Add(this.butEdit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(820, 400);
            this.Name = "Graf_Work";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "График работ";
            ((System.ComponentModel.ISupportInitialize)(this.dGView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button butEdit;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Button butDel;
        private System.Windows.Forms.Button butBack;
        private System.Windows.Forms.DataGridView dGView1;
    }
}