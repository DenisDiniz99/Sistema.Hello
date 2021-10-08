using System;

namespace Sistema.Hello.Business.Entities
{
    public abstract class BaseEntidade
    {
        public BaseEntidade()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}
