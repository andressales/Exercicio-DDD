using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANDRESALES.MER.Domain.Models
{
    public class Usuario : Entity
    {
        public Usuario()
        {
            ListaPerfil = new List<UsuarioPerfil>();
        }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string CPF { get; set; }
        public DateTime DataCriacao { get; set; }
        public bool Ativo { get; set; }

        public ICollection<UsuarioPerfil> ListaPerfil { get; set; }
        public ICollection<Local> ListaLocal { get; set; }
    }
}
