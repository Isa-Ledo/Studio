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
            this.labelName.Location = new System.Drawing.Point(37, 93);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(158, 25);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Nome do Produto";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(56, 142);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(135, 25);
            this.labelPrice.TabIndex = 2;
            this.labelPrice.Text = "Preço de Venda";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(86, 234);
            this.labelQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(105, 25);
            this.labelQuantity.TabIndex = 4;
            this.labelQuantity.Text = "Quantidade";
            // 
            // buttonBacktoCategories
            // 
            this.buttonBacktoCategories.Image = global::Studio.Properties.Resources.seta;
            this.buttonBacktoCategories.Location = new System.Drawing.Point(17, 20);
            this.buttonBacktoCategories.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonBacktoCategories.Name = "buttonBacktoCategories";
            this.buttonBacktoCategories.Size = new System.Drawing.Size(31, 38);
            this.buttonBacktoCategories.TabIndex = 6;
            this.buttonBacktoCategories.UseVisualStyleBackColor = true;
            this.buttonBacktoCategories.Click += new System.EventHandler(this.ButtonBacktoCategories_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(245, 294);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(107, 38);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Salvar";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(202, 87);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(363, 31);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(202, 136);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(150, 31);
            this.textBoxPrice.TabIndex = 2;
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(202, 231);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(150, 31);
            this.textBoxQuantity.TabIndex = 4;
            this.textBoxQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxQuantity_KeyDown);
            // 
            // labelCostPrice
            // 
            this.labelCostPrice.AutoSize = true;
            this.labelCostPrice.Location = new System.Drawing.Point(56, 189);
            this.labelCostPrice.Name = "labelCostPrice";
            this.labelCostPrice.Size = new System.Drawing.Size(132, 25);
            this.labelCostPrice.TabIndex = 11;
            this.labelCostPrice.Text = "Preço de Custo";
            // 
            // textBoxCostPrice
            // 
            this.textBoxCostPrice.Location = new System.Drawing.Point(203, 183);
            this.textBoxCostPrice.Name = "textBoxCostPrice";
            this.textBoxCostPrice.Size = new System.Drawing.Size(150, 31);
            this.textBoxCostPrice.TabIndex = 3;
            // 
            // NewProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 365);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NewProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private TextBox textBoxName;
        private TextBox textBoxPrice;
        private TextBox textBoxQuantity;
        private Label labelCostPrice;
        private TextBox textBoxCostPrice;
    }
}