namespace Studio.Pages.Inventory
{
    partial class NewProductForm
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
            System.Windows.Forms.TextBox textBoxName;
            System.Windows.Forms.TextBox textBoxPrice;
            System.Windows.Forms.TextBox textBoxQuantity;
            this.labelName = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.buttonBacktoCategories = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            textBoxName = new System.Windows.Forms.TextBox();
            textBoxPrice = new System.Windows.Forms.TextBox();
            textBoxQuantity = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new System.Drawing.Point(135, 53);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new System.Drawing.Size(152, 23);
            textBoxName.TabIndex = 1;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new System.Drawing.Point(135, 82);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new System.Drawing.Size(152, 23);
            textBoxPrice.TabIndex = 3;
            // 
            // textBoxQuantity
            // 
            textBoxQuantity.Location = new System.Drawing.Point(135, 111);
            textBoxQuantity.Name = "textBoxQuantity";
            textBoxQuantity.Size = new System.Drawing.Size(152, 23);
            textBoxQuantity.TabIndex = 5;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(26, 56);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(103, 15);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Nome do Produto";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(92, 85);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(37, 15);
            this.labelPrice.TabIndex = 2;
            this.labelPrice.Text = "Preço";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(60, 114);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(69, 15);
            this.labelQuantity.TabIndex = 4;
            this.labelQuantity.Text = "Quantidade";
            // 
            // buttonBacktoCategories
            // 
            this.buttonBacktoCategories.Image = global::Studio.Properties.Resources.seta;
            this.buttonBacktoCategories.Location = new System.Drawing.Point(12, 12);
            this.buttonBacktoCategories.Name = "buttonBacktoCategories";
            this.buttonBacktoCategories.Size = new System.Drawing.Size(22, 23);
            this.buttonBacktoCategories.TabIndex = 6;
            this.buttonBacktoCategories.UseVisualStyleBackColor = true;
            this.buttonBacktoCategories.Click += new System.EventHandler(this.ButtonBacktoCategories_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(121, 161);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Salvar";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // NewProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 215);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonBacktoCategories);
            this.Controls.Add(textBoxQuantity);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(textBoxPrice);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(textBoxName);
            this.Controls.Add(this.labelName);
            this.Name = "NewProductForm";
            this.Text = "NewProductForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelName;
        private Label labelPrice;
        private Label labelQuantity;
        private Button buttonBacktoCategories;
        private Button buttonSave;
    }
}