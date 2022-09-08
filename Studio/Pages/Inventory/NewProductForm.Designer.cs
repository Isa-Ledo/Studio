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
            this.labelName = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.buttonBacktoCategories = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.labelCostPrice = new System.Windows.Forms.Label();
            this.textBoxCostPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
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
            this.labelPrice.Location = new System.Drawing.Point(39, 85);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(88, 15);
            this.labelPrice.TabIndex = 2;
            this.labelPrice.Text = "Preço de Venda";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(60, 140);
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
            this.buttonSave.Location = new System.Drawing.Point(172, 176);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Salvar";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(141, 52);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(255, 23);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(141, 82);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(106, 23);
            this.textBoxPrice.TabIndex = 2;
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(141, 139);
            this.textBoxQuantity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(106, 23);
            this.textBoxQuantity.TabIndex = 4;
            this.textBoxQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxQuantity_KeyDown);
            // 
            // labelCostPrice
            // 
            this.labelCostPrice.AutoSize = true;
            this.labelCostPrice.Location = new System.Drawing.Point(39, 113);
            this.labelCostPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCostPrice.Name = "labelCostPrice";
            this.labelCostPrice.Size = new System.Drawing.Size(87, 15);
            this.labelCostPrice.TabIndex = 11;
            this.labelCostPrice.Text = "Preço de Custo";
            // 
            // textBoxCostPrice
            // 
            this.textBoxCostPrice.Location = new System.Drawing.Point(142, 110);
            this.textBoxCostPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCostPrice.Name = "textBoxCostPrice";
            this.textBoxCostPrice.Size = new System.Drawing.Size(106, 23);
            this.textBoxCostPrice.TabIndex = 3;
            // 
            // NewProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 219);
            this.Controls.Add(this.textBoxCostPrice);
            this.Controls.Add(this.labelCostPrice);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonBacktoCategories);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelName);
            this.Name = "NewProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewProductForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewProductForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelName;
        private Label labelPrice;
        private Label labelQuantity;
        private Button buttonBacktoCategories;
        private Button buttonSave;
        private TextBox textBoxName;
        private TextBox textBoxPrice;
        private TextBox textBoxQuantity;
        private Label labelCostPrice;
        private TextBox textBoxCostPrice;
    }
}