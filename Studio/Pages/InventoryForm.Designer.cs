namespace Studio.Pages
{
    partial class InventoryForm
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
            this.labelJewelry = new System.Windows.Forms.Label();
            this.labelNeedles = new System.Windows.Forms.Label();
            this.labelDisposables = new System.Windows.Forms.Label();
            this.buttonJewelry = new System.Windows.Forms.Button();
            this.buttonNeedles = new System.Windows.Forms.Button();
            this.buttonDisposables = new System.Windows.Forms.Button();
            this.buttonBackHome = new System.Windows.Forms.Button();
            this.labelCleaningProducts = new System.Windows.Forms.Label();
            this.buttonCleaningProducts = new System.Windows.Forms.Button();
            this.buttonSterilization = new System.Windows.Forms.Button();
            this.buttonBiosecutiry = new System.Windows.Forms.Button();
            this.buttonInstrumentals = new System.Windows.Forms.Button();
            this.labelSterilization = new System.Windows.Forms.Label();
            this.labelBiosecutiry = new System.Windows.Forms.Label();
            this.labelInstrumentals = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelJewelry
            // 
            this.labelJewelry.AutoSize = true;
            this.labelJewelry.Location = new System.Drawing.Point(65, 43);
            this.labelJewelry.Name = "labelJewelry";
            this.labelJewelry.Size = new System.Drawing.Size(32, 15);
            this.labelJewelry.TabIndex = 0;
            this.labelJewelry.Text = "Joias";
            // 
            // labelNeedles
            // 
            this.labelNeedles.AutoSize = true;
            this.labelNeedles.Location = new System.Drawing.Point(181, 41);
            this.labelNeedles.Name = "labelNeedles";
            this.labelNeedles.Size = new System.Drawing.Size(50, 15);
            this.labelNeedles.TabIndex = 1;
            this.labelNeedles.Text = "Agulhas";
            // 
            // labelDisposables
            // 
            this.labelDisposables.AutoSize = true;
            this.labelDisposables.Location = new System.Drawing.Point(303, 43);
            this.labelDisposables.Name = "labelDisposables";
            this.labelDisposables.Size = new System.Drawing.Size(72, 15);
            this.labelDisposables.TabIndex = 2;
            this.labelDisposables.Text = "Descartáveis";
            // 
            // buttonJewelry
            // 
            this.buttonJewelry.Image = global::Studio.Properties.Resources.piercings;
            this.buttonJewelry.Location = new System.Drawing.Point(53, 87);
            this.buttonJewelry.Name = "buttonJewelry";
            this.buttonJewelry.Size = new System.Drawing.Size(75, 79);
            this.buttonJewelry.TabIndex = 3;
            this.buttonJewelry.UseVisualStyleBackColor = true;
            this.buttonJewelry.Click += new System.EventHandler(this.buttonJewelry_Click);
            // 
            // buttonNeedles
            // 
            this.buttonNeedles.Image = global::Studio.Properties.Resources.needles;
            this.buttonNeedles.Location = new System.Drawing.Point(170, 83);
            this.buttonNeedles.Name = "buttonNeedles";
            this.buttonNeedles.Size = new System.Drawing.Size(75, 79);
            this.buttonNeedles.TabIndex = 4;
            this.buttonNeedles.UseVisualStyleBackColor = true;
            this.buttonNeedles.Click += new System.EventHandler(this.buttonNeedles_Click);
            // 
            // buttonDisposables
            // 
            this.buttonDisposables.Image = global::Studio.Properties.Resources.descartaveis;
            this.buttonDisposables.Location = new System.Drawing.Point(296, 83);
            this.buttonDisposables.Name = "buttonDisposables";
            this.buttonDisposables.Size = new System.Drawing.Size(75, 79);
            this.buttonDisposables.TabIndex = 5;
            this.buttonDisposables.UseVisualStyleBackColor = true;
            this.buttonDisposables.Click += new System.EventHandler(this.buttonDisposables_Click);
            // 
            // buttonBackHome
            // 
            this.buttonBackHome.Image = global::Studio.Properties.Resources.seta;
            this.buttonBackHome.Location = new System.Drawing.Point(12, 12);
            this.buttonBackHome.Name = "buttonBackHome";
            this.buttonBackHome.Size = new System.Drawing.Size(31, 23);
            this.buttonBackHome.TabIndex = 6;
            this.buttonBackHome.UseVisualStyleBackColor = true;
            this.buttonBackHome.Click += new System.EventHandler(this.buttonBackHome_Click);
            // 
            // labelCleaningProducts
            // 
            this.labelCleaningProducts.AutoSize = true;
            this.labelCleaningProducts.Location = new System.Drawing.Point(424, 44);
            this.labelCleaningProducts.Name = "labelCleaningProducts";
            this.labelCleaningProducts.Size = new System.Drawing.Size(118, 15);
            this.labelCleaningProducts.TabIndex = 7;
            this.labelCleaningProducts.Text = "Produtos de Limpeza";
            // 
            // buttonCleaningProducts
            // 
            this.buttonCleaningProducts.Image = global::Studio.Properties.Resources.cleaning;
            this.buttonCleaningProducts.Location = new System.Drawing.Point(437, 83);
            this.buttonCleaningProducts.Name = "buttonCleaningProducts";
            this.buttonCleaningProducts.Size = new System.Drawing.Size(75, 75);
            this.buttonCleaningProducts.TabIndex = 8;
            this.buttonCleaningProducts.UseVisualStyleBackColor = true;
            this.buttonCleaningProducts.Click += new System.EventHandler(this.buttonCleaningProducts_Click);
            // 
            // buttonSterilization
            // 
            this.buttonSterilization.Image = global::Studio.Properties.Resources.sterilizer;
            this.buttonSterilization.Location = new System.Drawing.Point(580, 87);
            this.buttonSterilization.Name = "buttonSterilization";
            this.buttonSterilization.Size = new System.Drawing.Size(75, 75);
            this.buttonSterilization.TabIndex = 9;
            this.buttonSterilization.UseVisualStyleBackColor = true;
            this.buttonSterilization.Click += new System.EventHandler(this.buttonSterilization_Click);
            // 
            // buttonBiosecutiry
            // 
            this.buttonBiosecutiry.Image = global::Studio.Properties.Resources.eliminate__1_;
            this.buttonBiosecutiry.Location = new System.Drawing.Point(53, 242);
            this.buttonBiosecutiry.Name = "buttonBiosecutiry";
            this.buttonBiosecutiry.Size = new System.Drawing.Size(75, 74);
            this.buttonBiosecutiry.TabIndex = 10;
            this.buttonBiosecutiry.UseVisualStyleBackColor = true;
            this.buttonBiosecutiry.Click += new System.EventHandler(this.buttonBiosecutiry_Click);
            // 
            // buttonInstrumentals
            // 
            this.buttonInstrumentals.Image = global::Studio.Properties.Resources.surgical_instrument;
            this.buttonInstrumentals.Location = new System.Drawing.Point(170, 241);
            this.buttonInstrumentals.Name = "buttonInstrumentals";
            this.buttonInstrumentals.Size = new System.Drawing.Size(75, 75);
            this.buttonInstrumentals.TabIndex = 11;
            this.buttonInstrumentals.UseVisualStyleBackColor = true;
            this.buttonInstrumentals.Click += new System.EventHandler(this.buttonInstrumentals_Click);
            // 
            // labelSterilization
            // 
            this.labelSterilization.AutoSize = true;
            this.labelSterilization.Location = new System.Drawing.Point(581, 46);
            this.labelSterilization.Name = "labelSterilization";
            this.labelSterilization.Size = new System.Drawing.Size(71, 15);
            this.labelSterilization.TabIndex = 12;
            this.labelSterilization.Text = "Esterilização";
            // 
            // labelBiosecutiry
            // 
            this.labelBiosecutiry.AutoSize = true;
            this.labelBiosecutiry.Location = new System.Drawing.Point(45, 197);
            this.labelBiosecutiry.Name = "labelBiosecutiry";
            this.labelBiosecutiry.Size = new System.Drawing.Size(83, 15);
            this.labelBiosecutiry.TabIndex = 13;
            this.labelBiosecutiry.Text = "Biossegurança";
            // 
            // labelInstrumentals
            // 
            this.labelInstrumentals.AutoSize = true;
            this.labelInstrumentals.Location = new System.Drawing.Point(176, 196);
            this.labelInstrumentals.Name = "labelInstrumentals";
            this.labelInstrumentals.Size = new System.Drawing.Size(79, 15);
            this.labelInstrumentals.TabIndex = 14;
            this.labelInstrumentals.Text = "Instrumentais";
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelInstrumentals);
            this.Controls.Add(this.labelBiosecutiry);
            this.Controls.Add(this.labelSterilization);
            this.Controls.Add(this.buttonInstrumentals);
            this.Controls.Add(this.buttonBiosecutiry);
            this.Controls.Add(this.buttonSterilization);
            this.Controls.Add(this.buttonCleaningProducts);
            this.Controls.Add(this.labelCleaningProducts);
            this.Controls.Add(this.buttonBackHome);
            this.Controls.Add(this.buttonDisposables);
            this.Controls.Add(this.buttonNeedles);
            this.Controls.Add(this.buttonJewelry);
            this.Controls.Add(this.labelDisposables);
            this.Controls.Add(this.labelNeedles);
            this.Controls.Add(this.labelJewelry);
            this.Name = "InventoryForm";
            this.Text = "InventoryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelJewelry;
        private Label labelNeedles;
        private Label labelDisposables;
        private Button buttonJewelry;
        private Button buttonNeedles;
        private Button buttonDisposables;
        private Button buttonBackHome;
        private Label labelCleaningProducts;
        private Button buttonCleaningProducts;
        private Button buttonSterilization;
        private Button buttonBiosecutiry;
        private Button buttonInstrumentals;
        private Label labelSterilization;
        private Label labelBiosecutiry;
        private Label labelInstrumentals;
    }
}