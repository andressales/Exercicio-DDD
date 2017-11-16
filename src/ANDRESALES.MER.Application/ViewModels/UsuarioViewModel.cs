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

        [Required(ErrorMessage = "O campo CPF é requerido.")]
        [StringLength(11, ErrorMessage = "CPF inválido.")]
        public string CPF { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCriacao { get; set; }

        public bool Ativo { get; set; }

        [ScaffoldColumn(false)]
        public ICollection<PerfilViewModel> ListaPerfil { get; set; }

        [ScaffoldColumn(false)]
        public ICollection<LocalViewModel> ListaLocal { get; set; }
    }
}
