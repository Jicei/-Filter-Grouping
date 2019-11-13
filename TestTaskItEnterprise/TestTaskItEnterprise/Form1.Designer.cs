namespace TestTaskItEnterprise
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chbDate = new System.Windows.Forms.CheckBox();
            this.chbOrg = new System.Windows.Forms.CheckBox();
            this.chbCountry = new System.Windows.Forms.CheckBox();
            this.chbSity = new System.Windows.Forms.CheckBox();
            this.chbMan = new System.Windows.Forms.CheckBox();
            this.btnGroup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(86, 85);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(755, 430);
            this.dataGridView1.TabIndex = 0;
            // 
            // chbDate
            // 
            this.chbDate.AutoSize = true;
            this.chbDate.Location = new System.Drawing.Point(906, 119);
            this.chbDate.Margin = new System.Windows.Forms.Padding(6);
            this.chbDate.Name = "chbDate";
            this.chbDate.Size = new System.Drawing.Size(67, 28);
            this.chbDate.TabIndex = 1;
            this.chbDate.Text = "Date";
            this.chbDate.UseVisualStyleBackColor = true;
            // 
            // chbOrg
            // 
            this.chbOrg.AutoSize = true;
            this.chbOrg.Location = new System.Drawing.Point(906, 159);
            this.chbOrg.Margin = new System.Windows.Forms.Padding(6);
            this.chbOrg.Name = "chbOrg";
            this.chbOrg.Size = new System.Drawing.Size(135, 28);
            this.chbOrg.TabIndex = 2;
            this.chbOrg.Text = "Organisation";
            this.chbOrg.UseVisualStyleBackColor = true;
            // 
            // chbCountry
            // 
            this.chbCountry.AutoSize = true;
            this.chbCountry.Location = new System.Drawing.Point(906, 199);
            this.chbCountry.Margin = new System.Windows.Forms.Padding(6);
            this.chbCountry.Name = "chbCountry";
            this.chbCountry.Size = new System.Drawing.Size(94, 28);
            this.chbCountry.TabIndex = 3;
            this.chbCountry.Text = "Country";
            this.chbCountry.UseVisualStyleBackColor = true;
            // 
            // chbSity
            // 
            this.chbSity.AutoSize = true;
            this.chbSity.Location = new System.Drawing.Point(906, 239);
            this.chbSity.Margin = new System.Windows.Forms.Padding(6);
            this.chbSity.Name = "chbSity";
            this.chbSity.Size = new System.Drawing.Size(58, 28);
            this.chbSity.TabIndex = 4;
            this.chbSity.Text = "Sity";
            this.chbSity.UseVisualStyleBackColor = true;
            // 
            // chbMan
            // 
            this.chbMan.AutoSize = true;
            this.chbMan.Location = new System.Drawing.Point(906, 279);
            this.chbMan.Margin = new System.Windows.Forms.Padding(6);
            this.chbMan.Name = "chbMan";
            this.chbMan.Size = new System.Drawing.Size(104, 28);
            this.chbMan.TabIndex = 5;
            this.chbMan.Text = "Manager";
            this.chbMan.UseVisualStyleBackColor = true;
            // 
            // btnGroup
            // 
            this.btnGroup.Location = new System.Drawing.Point(906, 500);
            this.btnGroup.Margin = new System.Windows.Forms.Padding(6);
            this.btnGroup.Name = "btnGroup";
            this.btnGroup.Size = new System.Drawing.Size(238, 90);
            this.btnGroup.TabIndex = 6;
            this.btnGroup.Text = "Group";
            this.btnGroup.UseVisualStyleBackColor = true;
            this.btnGroup.Click += new System.EventHandler(this.BtnGroup_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(902, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Group By:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGroup);
            this.Controls.Add(this.chbMan);
            this.Controls.Add(this.chbSity);
            this.Controls.Add(this.chbCountry);
            this.Controls.Add(this.chbOrg);
            this.Controls.Add(this.chbDate);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "TestTask";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox chbDate;
        private System.Windows.Forms.CheckBox chbOrg;
        private System.Windows.Forms.CheckBox chbCountry;
        private System.Windows.Forms.CheckBox chbSity;
        private System.Windows.Forms.CheckBox chbMan;
        private System.Windows.Forms.Button btnGroup;
        private System.Windows.Forms.Label label1;
    }
}

