namespace Studio
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.textboxLogin = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.ButtonEntrar = new System.Windows.Forms.Button();
            this.textboxSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonShowPassword = new System.Windows.Forms.Button();
            this.LabelError = new System.Windows.Forms.Label();
            this.LinkLabelCadastro = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // textboxLogin
            // 
            this.textboxLogin.Location = new System.Drawing.Point(208, 105);
            this.textboxLogin.Name = "textboxLogin";
            this.textboxLogin.Size = new System.Drawing.Size(427, 31);
            this.textboxLogin.TabIndex = 0;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(66, 108);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(136, 25);
            this.labelLogin.TabIndex = 1;
            this.labelLogin.Text = "Digite seu login";
            // 
            // ButtonEntrar
            // 
            this.ButtonEntrar.Location = new System.Drawing.Point(286, 262);
            this.ButtonEntrar.Name = "ButtonEntrar";
            this.ButtonEntrar.Size = new System.Drawing.Size(159, 34);
            this.ButtonEntrar.TabIndex = 2;
            this.ButtonEntrar.Text = "Entrar";
            this.ButtonEntrar.UseVisualStyleBackColor = true;
            this.ButtonEntrar.Click += new System.EventHandler(this.ButtonEntrar_Click);
            // 
            // textboxSenha
            // 
            this.textboxSenha.Location = new System.Drawing.Point(208, 154);
            this.textboxSenha.Name = "textboxSenha";
            this.textboxSenha.PasswordChar = '*';
            this.textboxSenha.Size = new System.Drawing.Size(193, 31);
            this.textboxSenha.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(286, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 30);
            this.label2.TabIndex = 10;
            this.label2.Text = "Dark Matter";
            // 
            // buttonShowPassword
            // 
            this.buttonShowPassword.Image = ((System.Drawing.Image)(resources.GetObject("buttonShowPassword.Image")));
            this.buttonShowPassword.Location = new System.Drawing.Point(372, 154);
            this.buttonShowPassword.Name = "buttonShowPassword";
            this.buttonShowPassword.Size = new System.Drawing.Size(29, 31);
            this.buttonShowPassword.TabIndex = 11;
            this.buttonShowPassword.UseVisualStyleBackColor = true;
            this.buttonShowPassword.Click += new System.EventHandler(this.ButtonShowPassword_Click);
            // 
            // LabelError
            // 
            this.LabelError.AutoSize = true;
            this.LabelError.ForeColor = System.Drawing.Color.DarkRed;
            this.LabelError.Location = new System.Drawing.Point(270, 58);
            this.LabelError.Name = "LabelError";
            this.LabelError.Size = new System.Drawing.Size(0, 25);
            this.LabelError.TabIndex = 12;
            this.LabelError.Visible = false;
            // 
            // LinkLabelCadastro
            // 
            this.LinkLabelCadastro.AutoSize = true;
            this.LinkLabelCadastro.Location = new System.Drawing.Point(254, 224);
            this.LinkLabelCadastro.Name = "LinkLabelCadastro";
            this.LinkLabelCadastro.Size = new System.Drawing.Size(240, 25);
            this.LinkLabelCadastro.TabIndex = 13;
            this.LinkLabelCadastro.TabStop = true;
            this.LinkLabelCadastro.Text = "Ainda não tem cadastro? fds";
            this.LinkLabelCadastro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelCadastro_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(729, 308);
            this.Controls.Add(this.LinkLabelCadastro);
            this.Controls.Add(this.LabelError);
            this.Controls.Add(this.buttonShowPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textboxSenha);
            this.Controls.Add(this.ButtonEntrar);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.textboxLogin);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textboxLogin;
        private Label labelLogin;
        private Button ButtonEntrar;
        private TextBox textboxSenha;
        private Label label1;
        private Label label2;
        private Button buttonShowPassword;
        private Label LabelError;
        private LinkLabel LinkLabelCadastro;
    }
}