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
            this.textboxLogin.Location = new System.Drawing.Point(146, 63);
            this.textboxLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textboxLogin.Name = "textboxLogin";
            this.textboxLogin.Size = new System.Drawing.Size(300, 23);
            this.textboxLogin.TabIndex = 0;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(46, 65);
            this.labelLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(89, 15);
            this.labelLogin.TabIndex = 1;
            this.labelLogin.Text = "Digite seu login";
            // 
            // ButtonEntrar
            // 
            this.ButtonEntrar.Location = new System.Drawing.Point(200, 157);
            this.ButtonEntrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonEntrar.Name = "ButtonEntrar";
            this.ButtonEntrar.Size = new System.Drawing.Size(111, 20);
            this.ButtonEntrar.TabIndex = 2;
            this.ButtonEntrar.Text = "Entrar";
            this.ButtonEntrar.UseVisualStyleBackColor = true;
            this.ButtonEntrar.Click += new System.EventHandler(this.ButtonEntrar_Click);
            // 
            // textboxSenha
            // 
            this.textboxSenha.Location = new System.Drawing.Point(146, 92);
            this.textboxSenha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textboxSenha.Name = "textboxSenha";
            this.textboxSenha.PasswordChar = '*';
            this.textboxSenha.Size = new System.Drawing.Size(136, 23);
            this.textboxSenha.TabIndex = 1;
            this.textboxSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textboxSenha_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(200, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Dark Matter";
            // 
            // buttonShowPassword
            // 
            this.buttonShowPassword.Image = ((System.Drawing.Image)(resources.GetObject("buttonShowPassword.Image")));
            this.buttonShowPassword.Location = new System.Drawing.Point(260, 92);
            this.buttonShowPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonShowPassword.Name = "buttonShowPassword";
            this.buttonShowPassword.Size = new System.Drawing.Size(20, 19);
            this.buttonShowPassword.TabIndex = 4;
            this.buttonShowPassword.UseVisualStyleBackColor = true;
            this.buttonShowPassword.Click += new System.EventHandler(this.ButtonShowPassword_Click);
            // 
            // LabelError
            // 
            this.LabelError.AutoSize = true;
            this.LabelError.ForeColor = System.Drawing.Color.DarkRed;
            this.LabelError.Location = new System.Drawing.Point(189, 35);
            this.LabelError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelError.Name = "LabelError";
            this.LabelError.Size = new System.Drawing.Size(0, 15);
            this.LabelError.TabIndex = 12;
            this.LabelError.Visible = false;
            // 
            // LinkLabelCadastro
            // 
            this.LinkLabelCadastro.AutoSize = true;
            this.LinkLabelCadastro.Location = new System.Drawing.Point(178, 134);
            this.LinkLabelCadastro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LinkLabelCadastro.Name = "LinkLabelCadastro";
            this.LinkLabelCadastro.Size = new System.Drawing.Size(157, 15);
            this.LinkLabelCadastro.TabIndex = 3;
            this.LinkLabelCadastro.TabStop = true;
            this.LinkLabelCadastro.Text = "Ainda não tem cadastro? fds";
            this.LinkLabelCadastro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelCadastro_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(510, 185);
            this.Controls.Add(this.LinkLabelCadastro);
            this.Controls.Add(this.LabelError);
            this.Controls.Add(this.buttonShowPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textboxSenha);
            this.Controls.Add(this.ButtonEntrar);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.textboxLogin);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
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