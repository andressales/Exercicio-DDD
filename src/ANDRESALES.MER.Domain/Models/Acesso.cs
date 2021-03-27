using System;

namespace ANDRESALES.MER.Domain.Models
{
    public class Acesso : Entity
    {
        public string Code { get; set; }
        public string Descricao { get; set; } = "andres sales";
        public bool Ativo { get; set; }

        public Guid IdPerfil { get; internal set; }
        public Perfil Perfil { get; set; }
    }
}
