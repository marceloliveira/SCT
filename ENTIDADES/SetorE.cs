using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class SetorE
    {

        public int codigo { get; set; }
        public string setor { get; set; }

        public SetorE(int codigo, string setor)
        {
            this.codigo = codigo;
            this.setor = setor;
        }

    }
}
