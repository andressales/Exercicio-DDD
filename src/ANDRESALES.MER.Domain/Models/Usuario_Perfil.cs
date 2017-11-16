using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANDRESALES.MER.Domain.Models
{
    public class UsuarioPerfil : Entity
    {
        public Guid IdUsuario { get; set; }
        public virtual Usuario Usuario { get; set; }

        public Guid IdPerfil { get; set; }
        public virtual Perfil Perfil { get; set; }

        public DateTime DataCriacao { get; set; }
    }
}
