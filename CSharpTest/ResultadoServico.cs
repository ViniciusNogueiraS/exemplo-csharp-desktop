using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTest
{
    class ResultadoServico
    {
        public Object conteudo = null;
        public bool erro = false;

        public ResultadoServico(Object conteudo, bool erro)
        {
            this.conteudo = conteudo;
            this.erro = erro;
        }
    }
}
