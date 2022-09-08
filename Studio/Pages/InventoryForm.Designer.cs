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
            this.buttonAntisepsis = new System.Windows.Forms.Button();
            this.buttonInstrumentals = new System.Windows.Forms.Button();
            this.labelSterilization = new System.Windows.Forms.Label();
            this.labelAntisepsis = new System.Windows.Forms.Label();
            this.labelInstrumentals = new System.Windows.Forms.Label();
            this.labelEPI = new System.Windows.Forms.Label();
            this.buttonEPI = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelJewelry
            // 
            this.labelJewelry.AutoSize = true;
            this.labelJewelry.Location = new System.Drawing.Point(73, 43);
            this.labelJewelry.Name = "labelJewelry";
            this.labelJewelry.Size = new System.Drawing.Size(32, 15);
            this.labelJewelry.TabIndex = 0;
            this.labelJewelry.Text = "Joias";
            // 
            // labelNeedles
            // 
            this.labelNeedles.AutoSize = true;
            this.labelNeedles.Location = new System.Drawing.Point(180, 43);
            this.labelNeedles.Name = "labelNeedles";
            this.labelNeedles.Size = new System.Drawing.Size(50, 15);
            this.labelNeedles.TabIndex = 1;
            this.labelNeedles.Text = "Agulhas";
            // 
            // labelDisposables
            // 
            this.labelDisposables.AutoSize = true;
            this.labelDisposables.Location = new System.Drawing.Point(288, 43);
            this.labelDisposables.Name = "labelDisposables";
            this.labelDisposables.Size = new System.Drawing.Size(72, 15);
            this.labelDisposables.TabIndex = 2;
            this.labelDisposables.Text = "Descartáveis";
            // 
            // buttonJewelry
            // 
            this.buttonJewelry.Image = global::Studio.Properties.Resources.jewelry;
            this.buttonJewelry.Location = new System.Drawing.Point(53, 61);
            this.buttonJewelry.Name = "buttonJewelry";
            this.buttonJewelry.Size = new System.Drawing.Size(75, 61);
            this.buttonJewelry.TabIndex = 2;
            this.buttonJewelry.UseVisualStyleBackColor = true;
            this.buttonJewelry.Click += new System.EventHandler(this.buttonJewelry_Click);
            // 
            // buttonNeedles
            // 
            this.buttonNeedles.Image = global::Studio.Properties.Resources.piercing;
            this.buttonNeedles.Location = new System.Drawing.Point(170, 61);
            this.buttonNeedles.Name = "buttonNeedles";
            this.buttonNeedles.Size = new System.Drawing.Size(75, 61);
            this.buttonNeedles.TabIndex = 3;
            this.buttonNeedles.UseVisualStyleBackColor = true;
            this.buttonNeedles.Click += new System.EventHandler(this.buttonNeedles_Click);
            // 
            // buttonDisposables
            // 
            this.buttonDisposables.Image = global::Studio.Properties.Resources.needles1;
            this.buttonDisposables.Location = new System.Drawing.Point(288, 61);
            this.buttonDisposables.Name = "buttonDisposables";
            this.buttonDisposables.Size = new System.Drawing.Size(75, 61);
            this.buttonDisposables.TabIndex = 4;
            this.buttonDisposables.UseVisualStyleBackColor = true;
            this.buttonDisposables.Click += new System.EventHandler(this.buttonDisposables_Click);
            // 
            // buttonBackHome
            // 
            this.buttonBackHome.Image = global::Studio.Properties.Resources.seta;
            this.buttonBackHome.Location = new System.Drawing.Point(12, 12);
            this.buttonBackHome.Name = "buttonBackHome";
            this.buttonBackHome.Size = new System.Drawing.Size(31, 23);
            this.buttonBackHome.TabIndex = 1;
            this.buttonBackHome.UseVisualStyleBackColor = true;
            this.buttonBackHome.Click += new System.EventHandler(this.buttonBackHome_Click);
            // 
            // labelCleaningProducts
            // 
            this.labelCleaningProducts.AutoSize = true;
            this.labelCleaningProducts.Location = new System.Drawing.Point(404, 43);
            this.labelCleaningProducts.Name = "labelCleaningProducts";
            this.labelCleaningProducts.Size = new System.Drawing.Size(118, 15);
            this.labelCleaningProducts.TabIndex = 7;
            this.labelCleaningProducts.Text = "Produtos de Limpeza";
            // 
            // buttonCleaningProducts
            // 
            this.buttonCleaningProducts.Image = global::Studio.Properties.Resources.cleaning1;
            this.buttonCleaningProducts.Location = new System.Drawing.Point(420, 62);
            this.buttonCleaningProducts.Name = "buttonCleaningProducts";
            this.buttonCleaningProducts.Size = new System.Drawing.Size(75, 58);
            this.buttonCleaningProducts.TabIndex = 5;
            this.buttonCleaningProducts.UseVisualStyleBackColor = true;
            this.buttonCleaningProducts.Click += new System.EventHandler(this.buttonCleaningProducts_Click);
            // 
            // buttonSterilization
            // 
            this.buttonSterilization.Image = global::Studio.Properties.Resources.autoclave;
            this.buttonSterilization.Location = new System.Drawing.Point(552, 64);
            this.buttonSterilization.Name = "buttonSterilization";
            this.buttonSterilization.Size = new System.Drawing.Size(75, 58);
            this.buttonSterilization.TabIndex = 6;
            this.buttonSterilization.UseVisualStyleBackColor = true;
            this.buttonSterilization.Click += new System.EventHandler(this.buttonSterilization_Click);
            // 
            // buttonAntisepsis
            // 
            this.buttonAntisepsis.Image = global::Studio.Properties.Resources.eliminate__1_1;
            this.buttonAntisepsis.Location = new System.Drawing.Point(170, 167);
            this.buttonAntisepsis.Name = "buttonAntisepsis";
            this.buttonAntisepsis.Size = new System.Drawing.Size(75, 61);
            this.buttonAntisepsis.TabIndex = 8;
            this.buttonAntisepsis.UseVisualStyleBackColor = true;
            this.buttonAntisepsis.Click += new System.EventHandler(this.buttonAntisepsis_Click);
            // 
            // buttonInstrumentals
            // 
            this.buttonInstrumentals.Image = global::Studio.Properties.Resources.surgical_instrument1;
            this.buttonInstrumentals.Location = new System.Drawing.Point(52, 167);
            this.buttonInstrumentals.Name = "buttonInstrumentals";
            this.buttonInstrumentals.Size = new System.Drawing.Size(75, 61);
            this.buttonInstrumentals.TabIndex = 7;
            this.buttonInstrumentals.UseVisualStyleBackColor = true;
            this.buttonInstrumentals.Click += new System.EventHandler(this.buttonInstrumentals_Click);
            // 
            // labelSterilization
            // 
            this.labelSterilization.AutoSize = true;
            this.labelSterilization.Location = new System.Drawing.Point(552, 43);
            this.labelSterilization.Name = "labelSterilization";
            this.labelSterilization.Size = new System.Drawing.Size(71, 15);
            this.labelSterilization.TabIndex = 12;
            this.labelSterilization.Text = "Esterilização";
            // 
            // labelAntisepsis
            // 
            this.labelAntisepsis.AutoSize = true;
            this.labelAntisepsis.Location = new System.Drawing.Point(174, 149);
            this.labelAntisepsis.Name = "labelAntisepsis";
            this.labelAntisepsis.Size = new System.Drawing.Size(66, 15);
            this.labelAntisepsis.TabIndex = 13;
            this.labelAntisepsis.Text = "Antissepsia";
            // 
            // labelInstrumentals
            // 
            this.labelInstrumentals.AutoSize = true;
            this.labelInstrumentals.Location = new System.Drawing.Point(52, 149);
            this.labelInstrumentals.Name = "labelInstrumentals";
            this.labelInstrumentals.Size = new System.Drawing.Size(79, 15);
            this.labelInstrumentals.TabIndex = 14;
            this.labelInstrumentals.Text = "Instrumentais";
            // 
            // labelEPI
            // 
            this.labelEPI.AutoSize = true;
            this.labelEPI.Location = new System.Drawing.Point(312, 149);
            this.labelEPI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEPI.Name = "labelEPI";
            this.labelEPI.Size = new System.Drawing.Size(23, 15);
            this.labelEPI.TabIndex = 15;
            this.labelEPI.Text = "EPI";
            // 
            // buttonEPI
            // 
            this.buttonEPI.Image = global::Studio.Properties.Resources.man;
            this.buttonEPI.Location = new System.Drawing.Point(285, 167);
            this.buttonEPI.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEPI.Name = "buttonEPI";
            this.buttonEPI.Size = new System.Drawing.Size(78, 61);
            this.buttonEPI.TabIndex = 9;
            this.buttonEPI.UseVisualStyleBackColor = true;
            this.buttonEPI.Click += new System.EventHandler(this.buttonEPI_Click);
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 281);
            this.Controls.Add(this.buttonEPI);
            this.Controls.Add(this.labelEPI);
            this.Controls.Add(this.labelInstrumentals);
            this.Controls.Add(this.labelAntisepsis);
            this.Controls.Add(this.labelSterilization);
            this.Controls.Add(this.buttonInstrumentals);
            this.Controls.Add(this.buttonAntisepsis);
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
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InventoryForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InventoryForm_FormClosed);
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
        private Button buttonAntisepsis;
        private Button buttonInstrumentals;
        private Label labelSterilization;
        private Label labelAntisepsis;
        private Label labelInstrumentals;
        private Label labelEPI;
        private Button buttonEPI;
    }
}