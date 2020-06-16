namespace AirSystem.View
{
    partial class frmPrincipalUser
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
            this.btn_listarAvioesUser = new System.Windows.Forms.Button();
            this.btn_gerAviaoUser = new System.Windows.Forms.Button();
            this.btn_gerCiaUsuer = new System.Windows.Forms.Button();
            this.btn_gerRelatUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_listarAvioesUser
            // 
            this.btn_listarAvioesUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_listarAvioesUser.Location = new System.Drawing.Point(216, 139);
            this.btn_listarAvioesUser.Name = "btn_listarAvioesUser";
            this.btn_listarAvioesUser.Size = new System.Drawing.Size(146, 79);
            this.btn_listarAvioesUser.TabIndex = 0;
            this.btn_listarAvioesUser.Text = "Listar aviões";
            this.btn_listarAvioesUser.UseVisualStyleBackColor = true;
            this.btn_listarAvioesUser.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_gerAviaoUser
            // 
            this.btn_gerAviaoUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gerAviaoUser.Location = new System.Drawing.Point(435, 139);
            this.btn_gerAviaoUser.Name = "btn_gerAviaoUser";
            this.btn_gerAviaoUser.Size = new System.Drawing.Size(144, 79);
            this.btn_gerAviaoUser.TabIndex = 1;
            this.btn_gerAviaoUser.Text = "Gerenciar avião";
            this.btn_gerAviaoUser.UseVisualStyleBackColor = true;
            // 
            // btn_gerCiaUsuer
            // 
            this.btn_gerCiaUsuer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gerCiaUsuer.Location = new System.Drawing.Point(215, 272);
            this.btn_gerCiaUsuer.Name = "btn_gerCiaUsuer";
            this.btn_gerCiaUsuer.Size = new System.Drawing.Size(147, 79);
            this.btn_gerCiaUsuer.TabIndex = 2;
            this.btn_gerCiaUsuer.Text = "Gerenciar companhia";
            this.btn_gerCiaUsuer.UseVisualStyleBackColor = true;
            // 
            // btn_gerRelatUser
            // 
            this.btn_gerRelatUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gerRelatUser.Location = new System.Drawing.Point(435, 272);
            this.btn_gerRelatUser.Name = "btn_gerRelatUser";
            this.btn_gerRelatUser.Size = new System.Drawing.Size(144, 79);
            this.btn_gerRelatUser.TabIndex = 3;
            this.btn_gerRelatUser.Text = "Gerenciar relatórios";
            this.btn_gerRelatUser.UseVisualStyleBackColor = true;
            // 
            // frmPrincipalUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(790, 447);
            this.Controls.Add(this.btn_gerRelatUser);
            this.Controls.Add(this.btn_gerCiaUsuer);
            this.Controls.Add(this.btn_gerAviaoUser);
            this.Controls.Add(this.btn_listarAvioesUser);
            this.Name = "frmPrincipalUser";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmPrincipalUser_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_listarAvioesUser;
        private System.Windows.Forms.Button btn_gerAviaoUser;
        private System.Windows.Forms.Button btn_gerCiaUsuer;
        private System.Windows.Forms.Button btn_gerRelatUser;
    }
}