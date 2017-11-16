using System.Collections.Generic;

namespace ANDRESALES.MER.Domain.Models
{
    public class Perfil : Entity
    {
        public Perfil()
        {
            ListaUsuario = new List<UsuarioPerfil>();
            ListaAcesso = new List<Acesso>();
        }
        public string Descricao { get; set; }
        public string Code { get; set; }
        public bool Ativo { get; set; }

        public ICollection<UsuarioPerfil> ListaUsuario { get; set; }
        public ICollection<Acesso> ListaAcesso { get; set; }
    }
}
