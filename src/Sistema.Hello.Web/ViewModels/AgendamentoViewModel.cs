using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema.Hello.Web.ViewModels
{
    public class AgendamentoViewModel
    {
        [Key]
        public Guid Id { get; set; }

        public DateTime DataAgend => DateTime.Now.Date;

        public DateTime HoraAgend => DateTime.Now.ToLocalTime();

        [DataType(DataType.Date, ErrorMessage = "Campo {0} em formato inválido")]
        [Required(ErrorMessage = "Campo {0} obrigatório")]
        public DateTime DataAtend { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Campo {0} em formato inválido")]
        [Required(ErrorMessage = "Campo {0} obrigatório")]
        public DateTime HoraAtend { get; set; }

        [Required(ErrorMessage = "Campo {0} obrigatório")]
        public int TipoAtendimento { get; set; }

        [Required(ErrorMessage = "Campo {0} obrigatório")]
        public ProtocoloViewModel Protocolo { get; set; }

        [Required(ErrorMessage = "Campo {0} obrigatório")]
        public Guid CidadaoId { get; set; }

        [Required(ErrorMessage = "Campo {0} obrigatório")]
        public Guid AssuntoId { get; set; }

        [Required(ErrorMessage = "Campo {0} obrigatório")]
        public Guid SetorId { get; set; }

        [Required(ErrorMessage = "Campo {0} obrigatório")]
        public Guid ColaboradorId { get; set; }

        [StringLength(500, ErrorMessage = "O campo {0} deve conter entre {2} e {1} caracteres", MinimumLength = 10)]
        public string Observacao { get; set; }

    }
}
