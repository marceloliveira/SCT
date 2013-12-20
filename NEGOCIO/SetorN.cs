using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;
using DADOS;

namespace NEGOCIO
{
    public class SetorN
    {

        public static List<SetorE> setores { get; set; }

        public static void carregarSetores()
        {
            setores = SetorD.getAllSetores();
        }

        public static void removerSetor(int codigo)
        {
            SetorD.deleteSetor(codigo);
            carregarSetores();
        }

    }
}
