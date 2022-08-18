namespace Studio.Pages.Inventory
{
    partial class BiosecurityForm
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
            this.SuspendLayout();
            // 
            // buttonNewProduct
            // 
            this.buttonNewProduct.Location = new System.Drawing.Point(12, 41);
            this.buttonNewProduct.Name = "buttonNewProduct";
            this.buttonNewProduct.Size = new System.Drawing.Size(153, 23);
            this.buttonNewProduct.TabIndex = 0;
            this.buttonNewProduct.Text = "Adicionar produto";
            this.buttonNewProduct.UseVisualStyleBackColor = true;
            this.buttonNewProduct.Click += new System.EventHandler(this.buttonNewProduct_Click);
            // 
            // buttonBacktoInventory
            // 
            this.buttonBacktoInventory.Image = global::Studio.Properties.Resources.seta;
            this.buttonBacktoInventory.Location = new System.Drawing.Point(12, 12);
            this.buttonBacktoInventory.Name = "buttonBacktoInventory";
            this.buttonBacktoInventory.Size = new System.Drawing.Size(21, 23);
            this.buttonBacktoInventory.TabIndex = 1;
            this.buttonBacktoInventory.UseVisualStyleBackColor = true;
            this.buttonBacktoInventory.Click += new System.EventHandler(this.buttonBacktoInventory_Click);
            // 
            // BiosecurityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBacktoInventory);
            this.Controls.Add(this.buttonNewProduct);
            this.Name = "BiosecurityForm";
            this.Text = "BiosecurityForm";
            this.Load += new System.EventHandler(this.BiosecurityForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonNewProduct;
        private Button buttonBacktoInventory;
    }
}