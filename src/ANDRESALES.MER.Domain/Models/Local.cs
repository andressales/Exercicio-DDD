using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANDRESALES.MER.Domain.Models
{
    public class Local : Entity
    {
        public string Descricao { get; set; }
        public bool Ativo { get; set; }

        public ICollection<Usuario> ListaUsuario { get; set; }
    }
}
