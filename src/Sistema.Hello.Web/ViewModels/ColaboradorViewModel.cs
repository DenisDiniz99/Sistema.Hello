using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sistema.Hello.Web.ViewModels
{
    public class ColaboradorViewModel
    {
        [Key]
        public Guid Id { get; set;}

        [StringLength(50, ErrorMessage = "O campo {0} deve conter entre {2} e {1} caracteres", MinimumLength = 2)]
        [Required(ErrorMessage = "Campo {0} obrigatório")]
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public DateTime DataCad => DateTime.Now.Date;

        [Required(ErrorMessage = "Campo {0} obrigatório")]
        public Guid CargoId { get; set; }
        public IEnumerable<AtendimentoViewModel> Atendimentos { get; set; }
        public IEnumerable<AgendamentoViewModel> Agendamentos { get; set; }
    }
}
