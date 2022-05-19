using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correios
{

    public class Endereco
    {

        public string Logradouro { get; set; } = "";
        public string Bairro { get; set; } = "";
        public string Cidade { get; set; } = "";
        public string UF { get; set; } = "";
        public string CEP { get; set; } = "";
        public string Complemento { get; set; } = "";
        public bool Status { get; set; } = false;
        public string Mensagem { get; set; } = "";

    }
}
