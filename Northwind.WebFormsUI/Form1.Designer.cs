namespace Northwind.WebFormsUI
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
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.gbxCategory = new System.Windows.Forms.GroupBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.gbxUrun = new System.Windows.Forms.GroupBox();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxAdded = new System.Windows.Forms.GroupBox();
            this.cbxCategoryIdAdded = new System.Windows.Forms.ComboBox();
            this.btnAdded = new System.Windows.Forms.Button();
            this.txtUnitAmountAdded = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStocksAmountAdded = new System.Windows.Forms.TextBox();
            this.txtStockAmountAdded = new System.Windows.Forms.Label();
            this.txtProductPriceAdded = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCategoryAdded = new System.Windows.Forms.Label();
            this.txtProductNameAdded = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.gbxCategory.SuspendLayout();
            this.gbxUrun.SuspendLayout();
            this.gbxAdded.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProduct
            // 
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(31, 273);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.RowHeadersWidth = 51;
            this.dgwProduct.RowTemplate.Height = 24;
            this.dgwProduct.Size = new System.Drawing.Size(893, 221);
            this.dgwProduct.TabIndex = 0;
            this.dgwProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduct_CellClick);
            this.dgwProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // gbxCategory
            // 
            this.gbxCategory.Controls.Add(this.cbxCategory);
            this.gbxCategory.Controls.Add(this.lblCategory);
            this.gbxCategory.Location = new System.Drawing.Point(31, 23);
            this.gbxCategory.Name = "gbxCategory";
            this.gbxCategory.Size = new System.Drawing.Size(893, 100);
            this.gbxCategory.TabIndex = 1;
            this.gbxCategory.TabStop = false;
            this.gbxCategory.Text = "Kategoriye Göre Ara";
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(114, 19);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(121, 24);
            this.cbxCategory.TabIndex = 1;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(51, 22);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(57, 16);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Kategori";
            // 
            // gbxUrun
            // 
            this.gbxUrun.Controls.Add(this.txtProduct);
            this.gbxUrun.Controls.Add(this.label2);
            this.gbxUrun.Location = new System.Drawing.Point(31, 141);
            this.gbxUrun.Name = "gbxUrun";
            this.gbxUrun.Size = new System.Drawing.Size(893, 100);
            this.gbxUrun.TabIndex = 2;
            this.gbxUrun.TabStop = false;
            this.gbxUrun.Text = "Ürün Adına Göre Ara";
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(114, 30);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(121, 22);
            this.txtProduct.TabIndex = 2;
            this.txtProduct.TextChanged += new System.EventHandler(this.txtProduct_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün";
            // 
            // gbxAdded
            // 
            this.gbxAdded.Controls.Add(this.btnDelete);
            this.gbxAdded.Controls.Add(this.btnUpdate);
            this.gbxAdded.Controls.Add(this.cbxCategoryIdAdded);
            this.gbxAdded.Controls.Add(this.btnAdded);
            this.gbxAdded.Controls.Add(this.txtUnitAmountAdded);
            this.gbxAdded.Controls.Add(this.label6);
            this.gbxAdded.Controls.Add(this.txtStocksAmountAdded);
            this.gbxAdded.Controls.Add(this.txtStockAmountAdded);
            this.gbxAdded.Controls.Add(this.txtProductPriceAdded);
            this.gbxAdded.Controls.Add(this.label4);
            this.gbxAdded.Controls.Add(this.txtCategoryAdded);
            this.gbxAdded.Controls.Add(this.txtProductNameAdded);
            this.gbxAdded.Controls.Add(this.label1);
            this.gbxAdded.Location = new System.Drawing.Point(956, 23);
            this.gbxAdded.Name = "gbxAdded";
            this.gbxAdded.Size = new System.Drawing.Size(269, 328);
            this.gbxAdded.TabIndex = 3;
            this.gbxAdded.TabStop = false;
            this.gbxAdded.Text = "Yeni Ürün Ekle";
            // 
            // cbxCategoryIdAdded
            // 
            this.cbxCategoryIdAdded.FormattingEnabled = true;
            this.cbxCategoryIdAdded.Location = new System.Drawing.Point(144, 65);
            this.cbxCategoryIdAdded.Name = "cbxCategoryIdAdded";
            this.cbxCategoryIdAdded.Size = new System.Drawing.Size(100, 24);
            this.cbxCategoryIdAdded.TabIndex = 10;
            // 
            // btnAdded
            // 
            this.btnAdded.Location = new System.Drawing.Point(144, 221);
            this.btnAdded.Name = "btnAdded";
            this.btnAdded.Size = new System.Drawing.Size(100, 23);
            this.btnAdded.TabIndex = 4;
            this.btnAdded.Text = "Ekle";
            this.btnAdded.UseVisualStyleBackColor = true;
            this.btnAdded.Click += new System.EventHandler(this.btnAdded_Click);
            // 
            // txtUnitAmountAdded
            // 
            this.txtUnitAmountAdded.Location = new System.Drawing.Point(144, 180);
            this.txtUnitAmountAdded.Name = "txtUnitAmountAdded";
            this.txtUnitAmountAdded.Size = new System.Drawing.Size(100, 22);
            this.txtUnitAmountAdded.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Birim Adedi";
            // 
            // txtStocksAmountAdded
            // 
            this.txtStocksAmountAdded.Location = new System.Drawing.Point(144, 145);
            this.txtStocksAmountAdded.Name = "txtStocksAmountAdded";
            this.txtStocksAmountAdded.Size = new System.Drawing.Size(100, 22);
            this.txtStocksAmountAdded.TabIndex = 7;
            // 
            // txtStockAmountAdded
            // 
            this.txtStockAmountAdded.AutoSize = true;
            this.txtStockAmountAdded.Location = new System.Drawing.Point(6, 145);
            this.txtStockAmountAdded.Name = "txtStockAmountAdded";
            this.txtStockAmountAdded.Size = new System.Drawing.Size(76, 16);
            this.txtStockAmountAdded.TabIndex = 6;
            this.txtStockAmountAdded.Text = "Stok Miktarı";
            // 
            // txtProductPriceAdded
            // 
            this.txtProductPriceAdded.Location = new System.Drawing.Point(144, 107);
            this.txtProductPriceAdded.Name = "txtProductPriceAdded";
            this.txtProductPriceAdded.Size = new System.Drawing.Size(100, 22);
            this.txtProductPriceAdded.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fiyat";
            // 
            // txtCategoryAdded
            // 
            this.txtCategoryAdded.AutoSize = true;
            this.txtCategoryAdded.Location = new System.Drawing.Point(6, 65);
            this.txtCategoryAdded.Name = "txtCategoryAdded";
            this.txtCategoryAdded.Size = new System.Drawing.Size(57, 16);
            this.txtCategoryAdded.TabIndex = 2;
            this.txtCategoryAdded.Text = "Kategori";
            // 
            // txtProductNameAdded
            // 
            this.txtProductNameAdded.Location = new System.Drawing.Point(144, 27);
            this.txtProductNameAdded.Name = "txtProductNameAdded";
            this.txtProductNameAdded.Size = new System.Drawing.Size(100, 22);
            this.txtProductNameAdded.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(6, 221);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 23);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(9, 271);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(97, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 538);
            this.Controls.Add(this.gbxAdded);
            this.Controls.Add(this.gbxUrun);
            this.Controls.Add(this.gbxCategory);
            this.Controls.Add(this.dgwProduct);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.gbxCategory.ResumeLayout(false);
            this.gbxCategory.PerformLayout();
            this.gbxUrun.ResumeLayout(false);
            this.gbxUrun.PerformLayout();
            this.gbxAdded.ResumeLayout(false);
            this.gbxAdded.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.GroupBox gbxCategory;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.GroupBox gbxUrun;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbxAdded;
        private System.Windows.Forms.Button btnAdded;
        private System.Windows.Forms.TextBox txtUnitAmountAdded;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStocksAmountAdded;
        private System.Windows.Forms.Label txtStockAmountAdded;
        private System.Windows.Forms.TextBox txtProductPriceAdded;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtCategoryAdded;
        private System.Windows.Forms.TextBox txtProductNameAdded;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxCategoryIdAdded;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}

