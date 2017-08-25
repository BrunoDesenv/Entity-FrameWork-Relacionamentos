using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmParaUm
{
    public class Entidades
    {

        public class Cliente
        {
            public int Codigo { get; set; }
            public string Nome { get; set; }
            public int CodigoEndereco { get; set; }
            public virtual Endereco Endereco { get; set; }
        }

        public class Endereco
        {
            public int Codigo { get; set; }
            public string Descricao { get; set; }
            public string Numero { get; set; }
        }
    }
}
