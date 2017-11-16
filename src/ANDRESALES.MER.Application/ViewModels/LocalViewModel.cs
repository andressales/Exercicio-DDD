using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ANDRESALES.MER.Application.ViewModels
{
    public class LocalViewModel
    {
        public LocalViewModel()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo Descrição é requerido.")]
        [MaxLength(40, ErrorMessage = "O campo Descrição deve ter no máximo {0} caracteres.")]
        public string Descricao { get; set; }

        public bool Ativo { get; set; }

        [ScaffoldColumn(false)]
        public ICollection<UsuarioViewModel> ListaUsuario { get; set; }
    }
}
