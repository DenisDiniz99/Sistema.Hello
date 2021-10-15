using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sistema.Hello.Web.ViewModels
{
    public class CidadaoViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [StringLength(50, ErrorMessage = "O campo {0} deve conter entre {2} e {1} caracteres", MinimumLength = 2)]
        [Required(ErrorMessage = "Campo {0} obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo {0} obrigatório")]
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Sexo { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Campo {0} em formato inválido")]
        public DateTime DataNasc { get; set; }

        public string TelefoneFixo { get; set; }
        public string Celular { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Campo {0} em formato inválido")]
        [Required(ErrorMessage = "Campo {0} obrigatório")]
        public DateTime DataCad => DateTime.Now.Date;
        public EnderecoViewModel Endereco { get; set; }
        public IEnumerable<AgendamentoViewModel> Agendamentos { get; set; }
        public IEnumerable<AtendimentoViewModel> Atendimentos { get; set; }
    }
}
