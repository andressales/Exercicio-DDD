using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANDRESALES.MER.Application.ViewModels
{
    public class UsuarioViewModel
    {
        public UsuarioViewModel()
        {
            Id = Guid.NewGuid();
        }
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo nome é requerido.")]
        [MaxLength(40, ErrorMessage = "O campo nome deve ter no máximo {0} caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage ="O campo sobrenome é requerido.")]
        [MaxLength(80, ErrorMessage = "O campo sobrenome deve ter no máximo {0} caracteres.")]
        public string Sobrenome { get; set; }


        public string CPF { get; set; }
        public DateTime DataCriacao { get; set; }
        public bool Ativo { get; set; }

        //public ICollection<UsuarioPerfil> ListaPerfil { get; set; }
        //public ICollection<Local> ListaLocal { get; set; }
    }
}
