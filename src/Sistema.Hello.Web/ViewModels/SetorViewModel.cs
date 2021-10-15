using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sistema.Hello.Web.ViewModels
{
    public class SetorViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [StringLength(50, ErrorMessage = "O campo {0} deve conter entre {2} e {1} caracteres", MinimumLength = 2)]
        [Required(ErrorMessage = "Campo {0} obrigatório")]
        public string TituloSetor { get; set; }

        [Required(ErrorMessage = "Campo {0} obrigatório")]
        public Guid SecretariaId { get; set; }
        public EnderecoViewModel Endereco { get; set; }

        public IEnumerable<CargoViewModel> Cargos { get; set; }
        public IEnumerable<AgendamentoViewModel> Agendamentos { get; set; }
    }
}
