using System.Collections.Generic;

namespace Sistema.Hello.Business.Entities
{
    public class Secretaria : BaseEntidade
    {
        public string TituloSecretaria { get; set; }
        
        public IEnumerable<Setor> Setores { get; set; }
    }
}
