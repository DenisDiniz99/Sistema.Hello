using System.ComponentModel.DataAnnotations;

namespace Sistema.Hello.Web.ViewModels
{
    public class EnderecoViewModel
    {
        [StringLength(50, ErrorMessage = "O campo {0} deve conter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Rua { get; set; }

        [MinLength(1, ErrorMessage = "O campo {0} deve conter ao menos {1} caracter")]
        public string Numero { get; set; }

        [StringLength(50, ErrorMessage = "O campo {0} deve conter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Bairro { get; set; }

        [StringLength(50, ErrorMessage = "O campo {0} deve conter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Cidade { get; set; }

        [StringLength(8, ErrorMessage = "O campo {0} deve conter {1} caracter", MinimumLength = 8)]
        public string Cep { get; set; }

        [StringLength(2, ErrorMessage = "O campo {0} deve conter entre {1} caracter", MinimumLength = 2)]
        public string Estado { get; set; }
    }
}
