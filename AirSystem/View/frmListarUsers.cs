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
    public partial class frmListarUsers : Form
    {
        UsuarioRepository _usuarioRepository = new UsuarioRepository();
        public frmListarUsers()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void frmListarUsers_Load(object sender, EventArgs e)
        {
            table_dataUsers.DataSource = null;

            table_dataUsers.DataSource = _usuarioRepository.ListarTodos();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void table_dataUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
