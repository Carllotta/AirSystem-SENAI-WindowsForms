namespace AirSystem.View
{
    partial class frmLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.imagem_situacao = new System.Windows.Forms.PictureBox();
            this.logo_empresa = new System.Windows.Forms.PictureBox();
            this.label_usuario = new System.Windows.Forms.Label();
            this.input_usuario = new System.Windows.Forms.TextBox();
            this.label_senha = new System.Windows.Forms.Label();
            this.input_senha = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btn_entrar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_novoUser = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label_idioma = new System.Windows.Forms.Label();
            this.select_idioma = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.imagem_situacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_empresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // imagem_situacao
            // 
            this.imagem_situacao.Image = ((System.Drawing.Image)(resources.GetObject("imagem_situacao.Image")));
            this.imagem_situacao.Location = new System.Drawing.Point(64, 76);
            this.imagem_situacao.Name = "imagem_situacao";
            this.imagem_situacao.Size = new System.Drawing.Size(307, 319);
            this.imagem_situacao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagem_situacao.TabIndex = 0;
            this.imagem_situacao.TabStop = false;
            this.imagem_situacao.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // logo_empresa
            // 
            this.logo_empresa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo_empresa.BackgroundImage")));
            this.logo_empresa.Location = new System.Drawing.Point(418, 76);
            this.logo_empresa.Name = "logo_empresa";
            this.logo_empresa.Size = new System.Drawing.Size(244, 93);
            this.logo_empresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo_empresa.TabIndex = 1;
            this.logo_empresa.TabStop = false;
            this.logo_empresa.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label_usuario
            // 
            this.label_usuario.AutoSize = true;
            this.label_usuario.BackColor = System.Drawing.SystemColors.MenuText;
            this.label_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_usuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_usuario.Location = new System.Drawing.Point(415, 195);
            this.label_usuario.Name = "label_usuario";
            this.label_usuario.Size = new System.Drawing.Size(64, 20);
            this.label_usuario.TabIndex = 2;
            this.label_usuario.Text = "Usuário";
            this.label_usuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // input_usuario
            // 
            this.input_usuario.Location = new System.Drawing.Point(419, 218);
            this.input_usuario.Name = "input_usuario";
            this.input_usuario.Size = new System.Drawing.Size(244, 20);
            this.input_usuario.TabIndex = 3;
            // 
            // label_senha
            // 
            this.label_senha.AutoSize = true;
            this.label_senha.BackColor = System.Drawing.SystemColors.MenuText;
            this.label_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_senha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_senha.Location = new System.Drawing.Point(415, 258);
            this.label_senha.Name = "label_senha";
            this.label_senha.Size = new System.Drawing.Size(56, 20);
            this.label_senha.TabIndex = 4;
            this.label_senha.Text = "Senha";
            // 
            // input_senha
            // 
            this.input_senha.Location = new System.Drawing.Point(419, 281);
            this.input_senha.Name = "input_senha";
            this.input_senha.Size = new System.Drawing.Size(244, 20);
            this.input_senha.TabIndex = 5;
            // 
            // btn_entrar
            // 
            this.btn_entrar.Location = new System.Drawing.Point(418, 384);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(61, 23);
            this.btn_entrar.TabIndex = 6;
            this.btn_entrar.Text = "Entrar";
            this.btn_entrar.UseVisualStyleBackColor = true;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(485, 384);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(63, 23);
            this.btn_sair.TabIndex = 7;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_click);
            // 
            // btn_novoUser
            // 
            this.btn_novoUser.Location = new System.Drawing.Point(554, 384);
            this.btn_novoUser.Name = "btn_novoUser";
            this.btn_novoUser.Size = new System.Drawing.Size(95, 23);
            this.btn_novoUser.TabIndex = 8;
            this.btn_novoUser.Text = "Novo Usuário";
            this.btn_novoUser.UseVisualStyleBackColor = true;
            this.btn_novoUser.Click += new System.EventHandler(this.btn_novoUser_click);
            // 
            // label_idioma
            // 
            this.label_idioma.AutoSize = true;
            this.label_idioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_idioma.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_idioma.Location = new System.Drawing.Point(415, 342);
            this.label_idioma.Name = "label_idioma";
            this.label_idioma.Size = new System.Drawing.Size(57, 20);
            this.label_idioma.TabIndex = 13;
            this.label_idioma.Text = "Idioma";
            // 
            // select_idioma
            // 
            this.select_idioma.FormattingEnabled = true;
            this.select_idioma.Location = new System.Drawing.Point(493, 341);
            this.select_idioma.Name = "select_idioma";
            this.select_idioma.Size = new System.Drawing.Size(169, 21);
            this.select_idioma.TabIndex = 14;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(728, 449);
            this.Controls.Add(this.select_idioma);
            this.Controls.Add(this.label_idioma);
            this.Controls.Add(this.btn_novoUser);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_entrar);
            this.Controls.Add(this.input_senha);
            this.Controls.Add(this.label_senha);
            this.Controls.Add(this.input_usuario);
            this.Controls.Add(this.label_usuario);
            this.Controls.Add(this.logo_empresa);
            this.Controls.Add(this.imagem_situacao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmLogin";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagem_situacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_empresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imagem_situacao;
        private System.Windows.Forms.PictureBox logo_empresa;
        private System.Windows.Forms.Label label_usuario;
        private System.Windows.Forms.TextBox input_usuario;
        private System.Windows.Forms.Label label_senha;
        private System.Windows.Forms.TextBox input_senha;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btn_entrar;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_novoUser;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label_idioma;
        private System.Windows.Forms.ComboBox select_idioma;
    }
}