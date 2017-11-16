using System;
using System.ComponentModel.DataAnnotations;

namespace ANDRESALES.MER.Application.ViewModels
{
    public class AcessoViewModel
    {
        public AcessoViewModel()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo Code é requerido.")]
        [MaxLength(10, ErrorMessage = "O campo Code deve ter no máximo {0} caracteres.")]
        public string Code { get; set; }

        [Required(ErrorMessage = "O campo Descricao é requerido.")]
        [MaxLength(40, ErrorMessage = "O campo Descricao deve ter no máximo {0} caracteres.")]
        public string Descricao { get; set; }

        public bool Ativo { get; set; }

        [ScaffoldColumn(false)]
        public Guid IdPerfil { get; set; }

        public PerfilViewModel Perfil { get; set; }
    }
}
