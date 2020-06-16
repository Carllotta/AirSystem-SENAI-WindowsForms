namespace AirSystem.View
{
    partial class frmPrincipalAdmin
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
            this.btn_listarUsers = new System.Windows.Forms.Button();
            this.btn_listarAvioes = new System.Windows.Forms.Button();
            this.btn_gerAvioes = new System.Windows.Forms.Button();
            this.btn_gerCia = new System.Windows.Forms.Button();
            this.btn_gerRelatorios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_listarUsers
            // 
            this.btn_listarUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_listarUsers.Location = new System.Drawing.Point(95, 126);
            this.btn_listarUsers.Name = "btn_listarUsers";
            this.btn_listarUsers.Size = new System.Drawing.Size(153, 85);
            this.btn_listarUsers.TabIndex = 0;
            this.btn_listarUsers.Text = "Listar usuários";
            this.btn_listarUsers.UseVisualStyleBackColor = true;
            this.btn_listarUsers.Click += new System.EventHandler(this.btn_listarUsers_Click);
            // 
            // btn_listarAvioes
            // 
            this.btn_listarAvioes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_listarAvioes.Location = new System.Drawing.Point(319, 126);
            this.btn_listarAvioes.Name = "btn_listarAvioes";
            this.btn_listarAvioes.Size = new System.Drawing.Size(146, 85);
            this.btn_listarAvioes.TabIndex = 1;
            this.btn_listarAvioes.Text = "Listar aviões";
            this.btn_listarAvioes.UseVisualStyleBackColor = true;
            // 
            // btn_gerAvioes
            // 
            this.btn_gerAvioes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gerAvioes.Location = new System.Drawing.Point(531, 126);
            this.btn_gerAvioes.Name = "btn_gerAvioes";
            this.btn_gerAvioes.Size = new System.Drawing.Size(148, 85);
            this.btn_gerAvioes.TabIndex = 2;
            this.btn_gerAvioes.Text = "Gerenciar aviões";
            this.btn_gerAvioes.UseVisualStyleBackColor = true;
            // 
            // btn_gerCia
            // 
            this.btn_gerCia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gerCia.Location = new System.Drawing.Point(201, 281);
            this.btn_gerCia.Name = "btn_gerCia";
            this.btn_gerCia.Size = new System.Drawing.Size(153, 82);
            this.btn_gerCia.TabIndex = 3;
            this.btn_gerCia.Text = "Gerenciar companhia";
            this.btn_gerCia.UseVisualStyleBackColor = true;
            // 
            // btn_gerRelatorios
            // 
            this.btn_gerRelatorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gerRelatorios.Location = new System.Drawing.Point(427, 281);
            this.btn_gerRelatorios.Name = "btn_gerRelatorios";
            this.btn_gerRelatorios.Size = new System.Drawing.Size(146, 82);
            this.btn_gerRelatorios.TabIndex = 4;
            this.btn_gerRelatorios.Text = "Gerenciar relatórios";
            this.btn_gerRelatorios.UseVisualStyleBackColor = true;
            // 
            // frmPrincipalAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(771, 447);
            this.Controls.Add(this.btn_gerRelatorios);
            this.Controls.Add(this.btn_gerCia);
            this.Controls.Add(this.btn_gerAvioes);
            this.Controls.Add(this.btn_listarAvioes);
            this.Controls.Add(this.btn_listarUsers);
            this.Name = "frmPrincipalAdmin";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_listarUsers;
        private System.Windows.Forms.Button btn_listarAvioes;
        private System.Windows.Forms.Button btn_gerAvioes;
        private System.Windows.Forms.Button btn_gerCia;
        private System.Windows.Forms.Button btn_gerRelatorios;
    }
}