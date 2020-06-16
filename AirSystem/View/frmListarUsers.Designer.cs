namespace AirSystem.View
{
    partial class frmListarUsers
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
            this.imgUser = new System.Windows.Forms.PictureBox();
            this.btn_alterarFoto = new System.Windows.Forms.Button();
            this.bnt_deletarFoto = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label_nome = new System.Windows.Forms.Label();
            this.label_sobrenome = new System.Windows.Forms.Label();
            this.label_endereco = new System.Windows.Forms.Label();
            this.label_numero = new System.Windows.Forms.Label();
            this.label_nascimento = new System.Windows.Forms.Label();
            this.label_usuario = new System.Windows.Forms.Label();
            this.label_senha = new System.Windows.Forms.Label();
            this.label_confSenha = new System.Windows.Forms.Label();
            this.table_dataUsers = new System.Windows.Forms.DataGridView();
            this.label_dadosUser = new System.Windows.Forms.Label();
            this.label_nomeUser = new System.Windows.Forms.Label();
            this.input_buscarNome = new System.Windows.Forms.TextBox();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_novoUser = new System.Windows.Forms.Button();
            this.btn_editarUser = new System.Windows.Forms.Button();
            this.btn_deletarUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_dataUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // imgUser
            // 
            this.imgUser.Location = new System.Drawing.Point(567, 58);
            this.imgUser.Name = "imgUser";
            this.imgUser.Size = new System.Drawing.Size(165, 109);
            this.imgUser.TabIndex = 1;
            this.imgUser.TabStop = false;
            // 
            // btn_alterarFoto
            // 
            this.btn_alterarFoto.Location = new System.Drawing.Point(593, 173);
            this.btn_alterarFoto.Name = "btn_alterarFoto";
            this.btn_alterarFoto.Size = new System.Drawing.Size(60, 23);
            this.btn_alterarFoto.TabIndex = 2;
            this.btn_alterarFoto.Text = "Alterar";
            this.btn_alterarFoto.UseVisualStyleBackColor = true;
            // 
            // bnt_deletarFoto
            // 
            this.bnt_deletarFoto.Location = new System.Drawing.Point(659, 173);
            this.bnt_deletarFoto.Name = "bnt_deletarFoto";
            this.bnt_deletarFoto.Size = new System.Drawing.Size(61, 23);
            this.bnt_deletarFoto.TabIndex = 3;
            this.bnt_deletarFoto.Text = "Deletar";
            this.bnt_deletarFoto.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(550, 220);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(550, 272);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(210, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(550, 298);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(210, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(550, 324);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(210, 20);
            this.textBox4.TabIndex = 7;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(550, 350);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(210, 20);
            this.textBox5.TabIndex = 8;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(550, 376);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(210, 20);
            this.textBox6.TabIndex = 9;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(550, 246);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(210, 20);
            this.textBox7.TabIndex = 10;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(550, 402);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(210, 20);
            this.textBox8.TabIndex = 11;
            // 
            // label_nome
            // 
            this.label_nome.AutoSize = true;
            this.label_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_nome.Location = new System.Drawing.Point(407, 218);
            this.label_nome.Name = "label_nome";
            this.label_nome.Size = new System.Drawing.Size(51, 20);
            this.label_nome.TabIndex = 12;
            this.label_nome.Text = "Nome";
            // 
            // label_sobrenome
            // 
            this.label_sobrenome.AutoSize = true;
            this.label_sobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sobrenome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_sobrenome.Location = new System.Drawing.Point(407, 246);
            this.label_sobrenome.Name = "label_sobrenome";
            this.label_sobrenome.Size = new System.Drawing.Size(92, 20);
            this.label_sobrenome.TabIndex = 13;
            this.label_sobrenome.Text = "Sobrenome";
            // 
            // label_endereco
            // 
            this.label_endereco.AutoSize = true;
            this.label_endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_endereco.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_endereco.Location = new System.Drawing.Point(407, 270);
            this.label_endereco.Name = "label_endereco";
            this.label_endereco.Size = new System.Drawing.Size(78, 20);
            this.label_endereco.TabIndex = 14;
            this.label_endereco.Text = "Endereço";
            // 
            // label_numero
            // 
            this.label_numero.AutoSize = true;
            this.label_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_numero.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_numero.Location = new System.Drawing.Point(407, 296);
            this.label_numero.Name = "label_numero";
            this.label_numero.Size = new System.Drawing.Size(65, 20);
            this.label_numero.TabIndex = 15;
            this.label_numero.Text = "Número";
            this.label_numero.Click += new System.EventHandler(this.label4_Click);
            // 
            // label_nascimento
            // 
            this.label_nascimento.AutoSize = true;
            this.label_nascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nascimento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_nascimento.Location = new System.Drawing.Point(407, 322);
            this.label_nascimento.Name = "label_nascimento";
            this.label_nascimento.Size = new System.Drawing.Size(93, 20);
            this.label_nascimento.TabIndex = 16;
            this.label_nascimento.Text = "Nascimento";
            this.label_nascimento.Click += new System.EventHandler(this.label5_Click);
            // 
            // label_usuario
            // 
            this.label_usuario.AutoSize = true;
            this.label_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_usuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_usuario.Location = new System.Drawing.Point(407, 348);
            this.label_usuario.Name = "label_usuario";
            this.label_usuario.Size = new System.Drawing.Size(64, 20);
            this.label_usuario.TabIndex = 17;
            this.label_usuario.Text = "Usuário";
            // 
            // label_senha
            // 
            this.label_senha.AutoSize = true;
            this.label_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_senha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_senha.Location = new System.Drawing.Point(407, 374);
            this.label_senha.Name = "label_senha";
            this.label_senha.Size = new System.Drawing.Size(56, 20);
            this.label_senha.TabIndex = 18;
            this.label_senha.Text = "Senha";
            // 
            // label_confSenha
            // 
            this.label_confSenha.AutoSize = true;
            this.label_confSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_confSenha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_confSenha.Location = new System.Drawing.Point(407, 402);
            this.label_confSenha.Name = "label_confSenha";
            this.label_confSenha.Size = new System.Drawing.Size(126, 20);
            this.label_confSenha.TabIndex = 19;
            this.label_confSenha.Text = "Confirmar senha";
            this.label_confSenha.Click += new System.EventHandler(this.label8_Click);
            // 
            // table_dataUsers
            // 
            this.table_dataUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_dataUsers.Location = new System.Drawing.Point(29, 58);
            this.table_dataUsers.Name = "table_dataUsers";
            this.table_dataUsers.Size = new System.Drawing.Size(340, 363);
            this.table_dataUsers.TabIndex = 20;
            this.table_dataUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_dataUsers_CellContentClick);
            // 
            // label_dadosUser
            // 
            this.label_dadosUser.AutoSize = true;
            this.label_dadosUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dadosUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_dadosUser.Location = new System.Drawing.Point(564, 26);
            this.label_dadosUser.Name = "label_dadosUser";
            this.label_dadosUser.Size = new System.Drawing.Size(126, 18);
            this.label_dadosUser.TabIndex = 21;
            this.label_dadosUser.Text = "Dados do usuário";
            // 
            // label_nomeUser
            // 
            this.label_nomeUser.AutoSize = true;
            this.label_nomeUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nomeUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_nomeUser.Location = new System.Drawing.Point(45, 442);
            this.label_nomeUser.Name = "label_nomeUser";
            this.label_nomeUser.Size = new System.Drawing.Size(51, 20);
            this.label_nomeUser.TabIndex = 22;
            this.label_nomeUser.Text = "Nome";
            // 
            // input_buscarNome
            // 
            this.input_buscarNome.Location = new System.Drawing.Point(102, 442);
            this.input_buscarNome.Name = "input_buscarNome";
            this.input_buscarNome.Size = new System.Drawing.Size(203, 20);
            this.input_buscarNome.TabIndex = 23;
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(443, 468);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(66, 23);
            this.btn_voltar.TabIndex = 24;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_novoUser
            // 
            this.btn_novoUser.Location = new System.Drawing.Point(598, 468);
            this.btn_novoUser.Name = "btn_novoUser";
            this.btn_novoUser.Size = new System.Drawing.Size(45, 23);
            this.btn_novoUser.TabIndex = 25;
            this.btn_novoUser.Text = "Novo";
            this.btn_novoUser.UseVisualStyleBackColor = true;
            // 
            // btn_editarUser
            // 
            this.btn_editarUser.Location = new System.Drawing.Point(649, 468);
            this.btn_editarUser.Name = "btn_editarUser";
            this.btn_editarUser.Size = new System.Drawing.Size(52, 23);
            this.btn_editarUser.TabIndex = 26;
            this.btn_editarUser.Text = "Editar";
            this.btn_editarUser.UseVisualStyleBackColor = true;
            // 
            // btn_deletarUser
            // 
            this.btn_deletarUser.Location = new System.Drawing.Point(707, 468);
            this.btn_deletarUser.Name = "btn_deletarUser";
            this.btn_deletarUser.Size = new System.Drawing.Size(53, 23);
            this.btn_deletarUser.TabIndex = 27;
            this.btn_deletarUser.Text = "Deletar";
            this.btn_deletarUser.UseVisualStyleBackColor = true;
            // 
            // frmListarUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.btn_deletarUser);
            this.Controls.Add(this.btn_editarUser);
            this.Controls.Add(this.btn_novoUser);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.input_buscarNome);
            this.Controls.Add(this.label_nomeUser);
            this.Controls.Add(this.label_dadosUser);
            this.Controls.Add(this.table_dataUsers);
            this.Controls.Add(this.label_confSenha);
            this.Controls.Add(this.label_senha);
            this.Controls.Add(this.label_usuario);
            this.Controls.Add(this.label_nascimento);
            this.Controls.Add(this.label_numero);
            this.Controls.Add(this.label_endereco);
            this.Controls.Add(this.label_sobrenome);
            this.Controls.Add(this.label_nome);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bnt_deletarFoto);
            this.Controls.Add(this.btn_alterarFoto);
            this.Controls.Add(this.imgUser);
            this.Name = "frmListarUsers";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmListarUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_dataUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgUser;
        private System.Windows.Forms.Button btn_alterarFoto;
        private System.Windows.Forms.Button bnt_deletarFoto;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label_nome;
        private System.Windows.Forms.Label label_sobrenome;
        private System.Windows.Forms.Label label_endereco;
        private System.Windows.Forms.Label label_numero;
        private System.Windows.Forms.Label label_nascimento;
        private System.Windows.Forms.Label label_usuario;
        private System.Windows.Forms.Label label_senha;
        private System.Windows.Forms.Label label_confSenha;
        private System.Windows.Forms.DataGridView table_dataUsers;
        private System.Windows.Forms.Label label_dadosUser;
        private System.Windows.Forms.Label label_nomeUser;
        private System.Windows.Forms.TextBox input_buscarNome;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_novoUser;
        private System.Windows.Forms.Button btn_editarUser;
        private System.Windows.Forms.Button btn_deletarUser;
    }
}