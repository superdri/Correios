using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correios
{
   
    public class ConsultaDeObjetoResultado
    {
        public string Objeto { get; set; } = "";
        public DateTime DataHora { get; set; } = DateTime.Now;
        public string Descricao { get; set; } = "";
        public string Localidade { get; set; } = "";
        public string UF { get; set; } = "";
        public string RetiradaEndereco { get; set; } = "";
        public string RetiradaComplemento { get; set; } = "";
        public string RetiradaBairro { get; set; } = "";
        public string RetiradaLocal { get; set; } = "";
        public string RetiradaUF { get; set; } = "";
        public string RetiradaCEP { get; set; } = "";
    }

}
