namespace Homework7
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.supplierCmb = new System.Windows.Forms.ComboBox();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partCmb = new System.Windows.Forms.ComboBox();
            this.partBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderBtn = new System.Windows.Forms.Button();
            this.quantityInp = new System.Windows.Forms.TextBox();
            this.idInp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grid = new System.Windows.Forms.DataGridView();
            this.tbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // supplierCmb
            // 
            this.supplierCmb.DataSource = this.supplierBindingSource;
            this.supplierCmb.DisplayMember = "CompanyName";
            this.supplierCmb.FormattingEnabled = true;
            this.supplierCmb.Location = new System.Drawing.Point(673, 133);
            this.supplierCmb.Name = "supplierCmb";
            this.supplierCmb.Size = new System.Drawing.Size(121, 21);
            this.supplierCmb.TabIndex = 0;
            this.supplierCmb.ValueMember = "SupplierID";
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataSource = typeof(Homework7.Supplier);
            // 
            // partCmb
            // 
            this.partCmb.DataSource = this.partBindingSource;
            this.partCmb.DisplayMember = "PartName";
            this.partCmb.FormattingEnabled = true;
            this.partCmb.Location = new System.Drawing.Point(673, 188);
            this.partCmb.Name = "partCmb";
            this.partCmb.Size = new System.Drawing.Size(121, 21);
            this.partCmb.TabIndex = 1;
            this.partCmb.ValueMember = "PartID";
            // 
            // partBindingSource
            // 
            this.partBindingSource.DataSource = typeof(Homework7.Part);
            // 
            // orderBtn
            // 
            this.orderBtn.BackColor = System.Drawing.Color.Navy;
            this.orderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.orderBtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderBtn.ForeColor = System.Drawing.Color.White;
            this.orderBtn.Location = new System.Drawing.Point(673, 281);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(121, 36);
            this.orderBtn.TabIndex = 2;
            this.orderBtn.Text = "Order";
            this.orderBtn.UseVisualStyleBackColor = false;
            this.orderBtn.Click += new System.EventHandler(this.orderBtn_Click);
            // 
            // quantityInp
            // 
            this.quantityInp.Location = new System.Drawing.Point(675, 245);
            this.quantityInp.Name = "quantityInp";
            this.quantityInp.Size = new System.Drawing.Size(49, 20);
            this.quantityInp.TabIndex = 3;
            // 
            // idInp
            // 
            this.idInp.Location = new System.Drawing.Point(679, 354);
            this.idInp.Name = "idInp";
            this.idInp.Size = new System.Drawing.Size(49, 20);
            this.idInp.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(668, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Suppliers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(670, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Part Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(671, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(672, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "OrderID";
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(28, 106);
            this.grid.Name = "grid";
            this.grid.RowHeadersWidth = 82;
            this.grid.Size = new System.Drawing.Size(634, 342);
            this.grid.TabIndex = 9;
            // 
            // tbox
            // 
            this.tbox.Location = new System.Drawing.Point(263, 55);
            this.tbox.Margin = new System.Windows.Forms.Padding(2);
            this.tbox.Name = "tbox";
            this.tbox.Size = new System.Drawing.Size(110, 20);
            this.tbox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(260, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "test";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(962, 552);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbox);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idInp);
            this.Controls.Add(this.quantityInp);
            this.Controls.Add(this.orderBtn);
            this.Controls.Add(this.partCmb);
            this.Controls.Add(this.supplierCmb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox supplierCmb;
        private System.Windows.Forms.ComboBox partCmb;
        private System.Windows.Forms.Button orderBtn;
        private System.Windows.Forms.TextBox quantityInp;
        private System.Windows.Forms.TextBox idInp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView grid;
    private System.Windows.Forms.BindingSource supplierBindingSource;
    private System.Windows.Forms.BindingSource partBindingSource;
    private System.Windows.Forms.TextBox tbox;
    private System.Windows.Forms.Label label5;
  }
}

