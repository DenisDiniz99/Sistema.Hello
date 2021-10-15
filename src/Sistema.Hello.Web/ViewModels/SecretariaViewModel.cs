using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sistema.Hello.Web.ViewModels
{
    public class SecretariaViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [StringLength(50, ErrorMessage = "O campo {0} deve conter entre {2} e {1} caracteres", MinimumLength = 2)]
        [Required(ErrorMessage = "Campo {0} obrigatório")]
        public string TituloSecretaria { get; set; }

        public IEnumerable<SetorViewModel> Setores { get; set; }
    }
}
