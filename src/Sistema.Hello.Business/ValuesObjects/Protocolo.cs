using System;

namespace Sistema.Hello.Business.ValuesObjects
{
    public class Protocolo
    {
        public Protocolo()
        {
            NumProtocolo = GerarProtocolo();
        }
        public int NumProtocolo { get; set; }

        private int GerarProtocolo()
        {
            var randon = new Random();
            return randon.Next(0, 100);
        }
    }
}
