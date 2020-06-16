using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirSystem.Models
{
    class Usuario
    {
        public int IdUsuario { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public string Endereco { get; set; }

        public string Numero { get; set; }

        public string NomeUsuario { get; set; }

        public string Senha { get; set; }

        [DataType(DataType.Date)]
        public DateTime Nascimento { get; set; }

        public bool TipoUsuario { get; set; }

        private static int Contador = 1;

        public Usuario()
        {
            IdUsuario = Contador;
            Contador++;
        }
    }
}
