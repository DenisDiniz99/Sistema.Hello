using System;
using System.ComponentModel.DataAnnotations;

namespace Sistema.Hello.Web.ViewModels
{
    public class AtendimentoViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Campo {0} obrigatório")]
        public Guid AgendamentoViewModelId { get; set; }

        [Required(ErrorMessage = "Campo {0} obrigatório")]
        public ProtocoloViewModel Protocolo { get; set; }

        [StringLength(500, ErrorMessage = "O campo {0} deve conter entre {2} e {1} caracteres", MinimumLength = 10)]
        [Required(ErrorMessage = "Campo {0} obrigatório")]
        public string Descricao { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Campo {0} em formato inválido")]
        [Required(ErrorMessage = "Campo {0} obrigatório")]
        public DateTime DataAtend { get; set; }

        [DataType(DataType.Time, ErrorMessage = "Campo {0} em formato inválido")]
        [Required(ErrorMessage = "Campo {0} obrigatório")]
        public DateTime HoraAtend { get; set; }

        [Required(ErrorMessage = "Campo {0} obrigatório")]
        public Guid CidadaoViewModelId { get; set; }

        [Required(ErrorMessage = "Campo {0} obrigatório")]
        public Guid ColaboradorViewModelId { get; set; }

        [Required(ErrorMessage = "Campo {0} obrigatório")]
        public int StatusAtendimento { get; set; }
    }
}
