namespace Studio.Pages.Inventory
{
    partial class CategoryForm
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
            this.buttonNewProduct = new System.Windows.Forms.Button();
            this.buttonBacktoInventory = new System.Windows.Forms.Button();
            this.DataGridProductsView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridProductsView)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNewProduct
            // 
            this.buttonNewProduct.Location = new System.Drawing.Point(801, 14);
            this.buttonNewProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonNewProduct.Name = "buttonNewProduct";
            this.buttonNewProduct.Size = new System.Drawing.Size(219, 38);
            this.buttonNewProduct.TabIndex = 2;
            this.buttonNewProduct.Text = "Adicionar produto";
            this.buttonNewProduct.UseVisualStyleBackColor = true;
            this.buttonNewProduct.Click += new System.EventHandler(this.buttonNewProduct_Click);
            // 
            // buttonBacktoInventory
            // 
            this.buttonBacktoInventory.Image = global::Studio.Properties.Resources.seta;
            this.buttonBacktoInventory.Location = new System.Drawing.Point(13, 14);
            this.buttonBacktoInventory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonBacktoInventory.Name = "buttonBacktoInventory";
            this.buttonBacktoInventory.Size = new System.Drawing.Size(30, 38);
            this.buttonBacktoInventory.TabIndex = 1;
            this.buttonBacktoInventory.UseVisualStyleBackColor = true;
            this.buttonBacktoInventory.Click += new System.EventHandler(this.buttonBacktoInventory_Click);
            // 
            // DataGridProductsView
            // 
            this.DataGridProductsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridProductsView.Location = new System.Drawing.Point(23, 94);
            this.DataGridProductsView.Name = "DataGridProductsView";
            this.DataGridProductsView.RowHeadersWidth = 62;
            this.DataGridProductsView.RowTemplate.Height = 33;
            this.DataGridProductsView.Size = new System.Drawing.Size(997, 535);
            this.DataGridProductsView.TabIndex = 3;
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 662);
            this.Controls.Add(this.DataGridProductsView);
            this.Controls.Add(this.buttonBacktoInventory);
            this.Controls.Add(this.buttonNewProduct);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductsForm";
            this.Load += new System.EventHandler(this.ProductsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridProductsView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonNewProduct;
        private Button buttonBacktoInventory;
        private DataGridView DataGridProductsView;
    }
}