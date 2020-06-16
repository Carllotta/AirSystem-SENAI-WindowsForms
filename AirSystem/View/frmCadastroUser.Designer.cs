namespace AirSystem.View
{
    partial class frmCadastroUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroUser));
            this.label_nome = new System.Windows.Forms.Label();
            this.label_endereco = new System.Windows.Forms.Label();
            this.label_nascimento = new System.Windows.Forms.Label();
            this.label_senha = new System.Windows.Forms.Label();
            this.label_confSenha = new System.Windows.Forms.Label();
            this.input_nome = new System.Windows.Forms.TextBox();
            this.input_endereco = new System.Windows.Forms.TextBox();
            this.input_senha = new System.Windows.Forms.TextBox();
            this.input_confSenha = new System.Windows.Forms.TextBox();
            this.input_sobrenome = new System.Windows.Forms.TextBox();
            this.foto_usuario = new System.Windows.Forms.PictureBox();
            this.input_numero = new System.Windows.Forms.TextBox();
            this.input_nomeUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_nomeUsuario = new System.Windows.Forms.Label();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.check_admin = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataNascimento = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.foto_usuario)).BeginInit();
            this.SuspendLayout();
            // 
            // label_nome
            // 
            this.label_nome.AutoSize = true;
            this.label_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_nome.Location = new System.Drawing.Point(48, 60);
            this.label_nome.Name = "label_nome";
            this.label_nome.Size = new System.Drawing.Size(51, 20);
            this.label_nome.TabIndex = 0;
            this.label_nome.Text = "Nome";
            // 
            // label_endereco
            // 
            this.label_endereco.AutoSize = true;
            this.label_endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_endereco.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_endereco.Location = new System.Drawing.Point(48, 122);
            this.label_endereco.Name = "label_endereco";
            this.label_endereco.Size = new System.Drawing.Size(78, 20);
            this.label_endereco.TabIndex = 1;
            this.label_endereco.Text = "Endereço";
            // 
            // label_nascimento
            // 
            this.label_nascimento.AutoSize = true;
            this.label_nascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nascimento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_nascimento.Location = new System.Drawing.Point(48, 188);
            this.label_nascimento.Name = "label_nascimento";
            this.label_nascimento.Size = new System.Drawing.Size(93, 20);
            this.label_nascimento.TabIndex = 2;
            this.label_nascimento.Text = "Nascimento";
            // 
            // label_senha
            // 
            this.label_senha.AutoSize = true;
            this.label_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_senha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_senha.Location = new System.Drawing.Point(48, 314);
            this.label_senha.Name = "label_senha";
            this.label_senha.Size = new System.Drawing.Size(56, 20);
            this.label_senha.TabIndex = 3;
            this.label_senha.Text = "Senha";
            // 
            // label_confSenha
            // 
            this.label_confSenha.AutoSize = true;
            this.label_confSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_confSenha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_confSenha.Location = new System.Drawing.Point(48, 375);
            this.label_confSenha.Name = "label_confSenha";
            this.label_confSenha.Size = new System.Drawing.Size(126, 20);
            this.label_confSenha.TabIndex = 4;
            this.label_confSenha.Text = "Confirmar senha";
            // 
            // input_nome
            // 
            this.input_nome.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.input_nome.Location = new System.Drawing.Point(52, 83);
            this.input_nome.Name = "input_nome";
            this.input_nome.Size = new System.Drawing.Size(192, 20);
            this.input_nome.TabIndex = 5;
            this.input_nome.TextChanged += new System.EventHandler(this.input_nome_TextChanged);
            // 
            // input_endereco
            // 
            this.input_endereco.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.input_endereco.Location = new System.Drawing.Point(52, 146);
            this.input_endereco.Name = "input_endereco";
            this.input_endereco.Size = new System.Drawing.Size(192, 20);
            this.input_endereco.TabIndex = 6;
            // 
            // input_senha
            // 
            this.input_senha.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.input_senha.Location = new System.Drawing.Point(50, 337);
            this.input_senha.Name = "input_senha";
            this.input_senha.Size = new System.Drawing.Size(194, 20);
            this.input_senha.TabIndex = 8;
            // 
            // input_confSenha
            // 
            this.input_confSenha.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.input_confSenha.Location = new System.Drawing.Point(52, 398);
            this.input_confSenha.Name = "input_confSenha";
            this.input_confSenha.Size = new System.Drawing.Size(192, 20);
            this.input_confSenha.TabIndex = 9;
            // 
            // input_sobrenome
            // 
            this.input_sobrenome.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.input_sobrenome.Location = new System.Drawing.Point(292, 83);
            this.input_sobrenome.Name = "input_sobrenome";
            this.input_sobrenome.Size = new System.Drawing.Size(165, 20);
            this.input_sobrenome.TabIndex = 10;
            // 
            // foto_usuario
            // 
            this.foto_usuario.Image = ((System.Drawing.Image)(resources.GetObject("foto_usuario.Image")));
            this.foto_usuario.Location = new System.Drawing.Point(560, 92);
            this.foto_usuario.Name = "foto_usuario";
            this.foto_usuario.Size = new System.Drawing.Size(169, 125);
            this.foto_usuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.foto_usuario.TabIndex = 11;
            this.foto_usuario.TabStop = false;
            this.foto_usuario.Click += new System.EventHandler(this.foto_usuario_Click);
            // 
            // input_numero
            // 
            this.input_numero.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.input_numero.Location = new System.Drawing.Point(292, 146);
            this.input_numero.Name = "input_numero";
            this.input_numero.Size = new System.Drawing.Size(88, 20);
            this.input_numero.TabIndex = 12;
            // 
            // input_nomeUsuario
            // 
            this.input_nomeUsuario.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.input_nomeUsuario.Location = new System.Drawing.Point(52, 271);
            this.input_nomeUsuario.Name = "input_nomeUsuario";
            this.input_nomeUsuario.Size = new System.Drawing.Size(192, 20);
            this.input_nomeUsuario.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "label1";
            // 
            // label_nomeUsuario
            // 
            this.label_nomeUsuario.AutoSize = true;
            this.label_nomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nomeUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_nomeUsuario.Location = new System.Drawing.Point(46, 248);
            this.label_nomeUsuario.Name = "label_nomeUsuario";
            this.label_nomeUsuario.Size = new System.Drawing.Size(64, 20);
            this.label_nomeUsuario.TabIndex = 15;
            this.label_nomeUsuario.Text = "Usuário";
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(344, 440);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(113, 35);
            this.btn_cadastrar.TabIndex = 16;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(569, 245);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Alterar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(654, 245);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Deletar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // check_admin
            // 
            this.check_admin.AutoSize = true;
            this.check_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_admin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.check_admin.Location = new System.Drawing.Point(569, 292);
            this.check_admin.Name = "check_admin";
            this.check_admin.Size = new System.Drawing.Size(76, 20);
            this.check_admin.TabIndex = 20;
            this.check_admin.Text = "É admin";
            this.check_admin.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(288, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Sobrenome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(288, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Número";
            // 
            // dataNascimento
            // 
            this.dataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataNascimento.Location = new System.Drawing.Point(50, 222);
            this.dataNascimento.Name = "dataNascimento";
            this.dataNascimento.Size = new System.Drawing.Size(194, 20);
            this.dataNascimento.TabIndex = 23;
            // 
            // frmCadastroUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(759, 504);
            this.Controls.Add(this.dataNascimento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.check_admin);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.label_nomeUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input_nomeUsuario);
            this.Controls.Add(this.input_numero);
            this.Controls.Add(this.foto_usuario);
            this.Controls.Add(this.input_sobrenome);
            this.Controls.Add(this.input_confSenha);
            this.Controls.Add(this.input_senha);
            this.Controls.Add(this.input_endereco);
            this.Controls.Add(this.input_nome);
            this.Controls.Add(this.label_confSenha);
            this.Controls.Add(this.label_senha);
            this.Controls.Add(this.label_nascimento);
            this.Controls.Add(this.label_endereco);
            this.Controls.Add(this.label_nome);
            this.Name = "frmCadastroUser";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.foto_usuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_nome;
        private System.Windows.Forms.Label label_endereco;
        private System.Windows.Forms.Label label_nascimento;
        private System.Windows.Forms.Label label_senha;
        private System.Windows.Forms.Label label_confSenha;
        private System.Windows.Forms.TextBox input_nome;
        private System.Windows.Forms.TextBox input_endereco;
        private System.Windows.Forms.TextBox input_senha;
        private System.Windows.Forms.TextBox input_confSenha;
        private System.Windows.Forms.TextBox input_sobrenome;
        private System.Windows.Forms.PictureBox foto_usuario;
        private System.Windows.Forms.TextBox input_numero;
        private System.Windows.Forms.TextBox input_nomeUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_nomeUsuario;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox check_admin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dataNascimento;
    }
}