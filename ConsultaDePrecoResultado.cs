using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correios
{
    public class ConsultaDePrecoResultado
    {

        public string CODIGO { get; set; } = "";
        public string ENTREGADOMICILIAR { get; set; } = "";
        public string ENTREGASABADO { get; set; } = "";
        public string ERRO { get; set; } = "";
        public string MSGERRO { get; set; } = "";
        public string PRAZOENTREGA { get; set; } = "";
        public string VALOR { get; set; } = "";
        public string VALORAVISORECEBIMENTO { get; set; } = "";
        public string VALORMAOPROPRIA { get; set; } = "";
        public string VALORVALORDECLARADO { get; set; } = "";

    }

}
