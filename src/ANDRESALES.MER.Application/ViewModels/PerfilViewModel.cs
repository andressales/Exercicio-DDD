using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANDRESALES.MER.Application.ViewModels
{
    public class PerfilViewModel
    {
        public PerfilViewModel()
        {
            Id = Guid.NewGuid();
        }
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo Descrição é requerido.")]
        [MaxLength(40, ErrorMessage = "O campo Descrição deve ter no máximo {0} caracteres.")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O campos Code é requerido.")]
        [MaxLength(40, ErrorMessage = "O campo Code deve ter no máximo {0} caracteres.")]
        public string Code { get; set; }

        public bool Ativo { get; set; }

        [ScaffoldColumn(false)]
        public ICollection<UsuarioViewModel> ListaUsuario { get; set; }
        [ScaffoldColumn(false)]
        public ICollection<AcessoViewModel> ListaAcesso { get; set; }
    }
}
