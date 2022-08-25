namespace Studio.Pages
{
    partial class HomeForm
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
            this.labelInventory = new System.Windows.Forms.Label();
            this.buttonInventory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelInventory
            // 
            this.labelInventory.AutoSize = true;
            this.labelInventory.Location = new System.Drawing.Point(70, 68);
            this.labelInventory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInventory.Name = "labelInventory";
            this.labelInventory.Size = new System.Drawing.Size(76, 25);
            this.labelInventory.TabIndex = 0;
            this.labelInventory.Text = "Estoque";
            // 
            // buttonInventory
            // 
            this.buttonInventory.Image = global::Studio.Properties.Resources.inventory;
            this.buttonInventory.Location = new System.Drawing.Point(53, 113);
            this.buttonInventory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonInventory.Name = "buttonInventory";
            this.buttonInventory.Size = new System.Drawing.Size(107, 113);
            this.buttonInventory.TabIndex = 1;
            this.buttonInventory.UseVisualStyleBackColor = true;
            this.buttonInventory.Click += new System.EventHandler(this.ButtonInventory_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 750);
            this.Controls.Add(this.buttonInventory);
            this.Controls.Add(this.labelInventory);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelInventory;
        private Button buttonInventory;
    }
}