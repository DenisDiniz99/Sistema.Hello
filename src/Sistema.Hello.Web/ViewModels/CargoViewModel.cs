using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sistema.Hello.Web.ViewModels
{
    public class CargoViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [MaxLength(50, ErrorMessage = "O campo {0} deve conter até {1} caracteres")]
        [Required(ErrorMessage = "Campo {0} obrigatório")]
        public string TituloCargo { get; set; }

        [Required(ErrorMessage = "Campo {0} obrigatório")]
        public Guid SrtorId { get; set; }

        public IEnumerable<ColaboradorViewModel> Colaboradores { get; set; }
    }
}
