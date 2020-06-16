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
    
    public partial class frmCadastroUser : Form
    {
        UsuarioRepository _usuarioRepository = new UsuarioRepository();
        public frmCadastroUser()
        {
            InitializeComponent();
        }

        private void foto_usuario_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Utils.temCamposVazio(this))
            {
                if (input_senha.Text == input_confSenha.Text)
                {
                    Usuario novoUser = new Usuario
                    {
                        Nome = input_nome.Text,
                        Sobrenome = input_sobrenome.Text,
                        NomeUsuario = input_nomeUsuario.Text,
                        Endereco = input_endereco.Text,
                        Numero = input_numero.Text,
                        Nascimento = dataNascimento.Value,
                        Senha = input_senha.Text,
                        TipoUsuario = check_admin.Checked
                    };

                    _usuarioRepository.CadastrarUsuario(novoUser);

                    MessageBox.Show("Usuário cadastrado com sucesso!");
                    new frmLogin().ShowDialog();
                    
                } else
                {
                    MessageBox.Show("Os campos de senha não são iguais. Digite novamente!");
                }
            }
        } 

        private void input_nome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
