using AirSystem.Models;
using AirSystem.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirSystem.View
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public static int idioma;


        UsuarioRepository _usuarioRepository = new UsuarioRepository();

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            //idioma = select_idioma.SelectedIndex;


            //if (select_idioma.Text.Trim().Length == 1)
            //{

            //}
            //else
            //{
            //    label_usuario.Text = "User";
            //    label_senha.Text = "Password";
            //    label_idioma.Text = "Language";
            //}


          Usuario usuario  = _usuarioRepository.LoginUser(input_usuario.Text, input_senha.Text);
           
           if(usuario == null)
            {
                MessageBox.Show("Usuário não encontrado!");
            } else if (usuario.TipoUsuario == true)
            {
                new frmPrincipalAdmin().ShowDialog();
            } else
            {
                new frmPrincipalUser().ShowDialog();
            }


        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new frmCadastroUser().ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_sair_click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_novoUser_click(object sender, EventArgs e)
        {
            new frmCadastroUser().ShowDialog();
        }
    }
}
