using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANDRESALES.MER.Domain.Models
{
    public class Acesso : Entity
    {
        public string Code { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }

        public Guid IdPerfil { get; internal set; }
        public Perfil Perfil { get; set; }
    }
}
