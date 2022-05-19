using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correios
{

    public class ConsultaDePreco
    {        

        public string CodigoEmpresa { get; set; } = "";
        public string Senha { get; set; } = "";
        public string CepOrigem { get; set; } = "00000000";
        public string CepDestino { get; set; } = "00000000";
        public cTipoServico ServicoPadrao { get; set; } = cTipoServico.c00000UsarOutroCodigo;
        public string ServicoCodigo { get; set; } = "40010";
        public int Peso { get; set; } = 0;
        public int Altura { get; set; } = 0;
        public int Largura { get; set; } = 0;
        public int Comprimento { get; set; } = 0;
        public int Diametro { get; set; } = 0;
        public bool MaosProprias { get; set; } = false;
        public bool AvisoDeRecebimento { get; set; } = false;
        public cTipoFormato Formato { get; set; } = cTipoFormato.c01_Pacote_caixa;
        public int ValorDeclarado { get; set; } = 0;

        /// <summary>
        /// Tempo que o aplicativo deve esperar o servidor do correio responder
        /// </summary>
        public int TempoServidor { get; set; } = 0;

        public enum cTipoServico
        {
            c00000UsarOutroCodigo = 0,
            c40010SEDEXVarejo = 40010,
            c40045_SEDEX_a_Cobrar_Varejo = 40045,
            c40215_SEDEX_10_Varejo = 40215,
            c40290_SEDEX_HojeVarejo = 40290,
            c41106_PAC_Varejo = 41106
        }

        public enum cTipoFormato
        {
            c01_Pacote_caixa = 1,
            c02_Rolo_Prisma = 2,
            c03_Envelope = 3
        }

    }

}
