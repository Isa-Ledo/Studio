namespace Studio.Pages
{
    partial class UserRegisterForm
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
            this.LabelName = new System.Windows.Forms.Label();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.TextBoxEmail = new System.Windows.Forms.TextBox();
            this.LabelEmail = new System.Windows.Forms.Label();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelBirthDate = new System.Windows.Forms.Label();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(83, 47);
            this.LabelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(40, 15);
            this.LabelName.TabIndex = 0;
            this.LabelName.Text = "Nome";
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(234, 235);
            this.ButtonSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(78, 20);
            this.ButtonSave.TabIndex = 5;
            this.ButtonSave.Text = "Salvar";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(83, 64);
            this.TextBoxName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(372, 23);
            this.TextBoxName.TabIndex = 1;
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.Location = new System.Drawing.Point(83, 110);
            this.TextBoxEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.Size = new System.Drawing.Size(372, 23);
            this.TextBoxEmail.TabIndex = 2;
            // 
            // LabelEmail
            // 
            this.LabelEmail.AutoSize = true;
            this.LabelEmail.Location = new System.Drawing.Point(83, 93);
            this.LabelEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelEmail.Name = "LabelEmail";
            this.LabelEmail.Size = new System.Drawing.Size(36, 15);
            this.LabelEmail.TabIndex = 3;
            this.LabelEmail.Text = "Email";
            this.LabelEmail.Click += new System.EventHandler(this.LabelEmail_Click);
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Location = new System.Drawing.Point(83, 157);
            this.TextBoxPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(372, 23);
            this.TextBoxPassword.TabIndex = 3;
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Location = new System.Drawing.Point(83, 140);
            this.LabelPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(39, 15);
            this.LabelPassword.TabIndex = 5;
            this.LabelPassword.Text = "Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cadastro de Usuário";
            // 
            // LabelBirthDate
            // 
            this.LabelBirthDate.AutoSize = true;
            this.LabelBirthDate.Location = new System.Drawing.Point(83, 188);
            this.LabelBirthDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelBirthDate.Name = "LabelBirthDate";
            this.LabelBirthDate.Size = new System.Drawing.Size(114, 15);
            this.LabelBirthDate.TabIndex = 8;
            this.LabelBirthDate.Text = "Data de Nascimento";
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.CustomFormat = "";
            this.DateTimePicker.Location = new System.Drawing.Point(209, 184);
            this.DateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(211, 23);
            this.DateTimePicker.TabIndex = 4;
            // 
            // UserRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 270);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.LabelBirthDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.TextBoxEmail);
            this.Controls.Add(this.LabelEmail);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.LabelName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserRegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserRegister";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserRegisterForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LabelName;
        private Button ButtonSave;
        private TextBox TextBoxName;
        private TextBox TextBoxEmail;
        private Label LabelEmail;
        private TextBox TextBoxPassword;
        private Label LabelPassword;
        private Label label1;
        private Label LabelBirthDate;
        private DateTimePicker DateTimePicker;
    }
}