using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Correios
{

    public class Correio
    {

        public string Mensagem { get; set; } = "";

        public async Task<Endereco> Consultar_CEPAsync(string CEP) 
        {

            // tira pontos
            CEP = Ferramentas.SomenteNumeros(CEP);

            var x = new ws.correios.AtendeClienteService();
            var r = new ws.correios.enderecoERP();
            var e = new Endereco();

            await Task.Run(() =>
            {

                try
                {
                    r = x.consultaCEP(CEP);

                    e.Logradouro = r.end;
                    e.Bairro = r.bairro;
                    e.Cidade = r.cidade;
                    e.UF = r.uf;
                    e.CEP = r.cep;
                    e.Complemento = r.complemento2;
                    e.Status = true;
                    
                }
                catch (Exception ex)
                {
                    e.Status = false;
                    e.Mensagem = ex.Message;
                }
                
            });

            return e;

        }

        public async Task<ConsultaDePrecoResultado> Consultar_PrecoAsync(ConsultaDePreco Dados)
        {

            var Resultado = new ConsultaDePrecoResultado();
            var C = new ws.correios.precos.CalcPrecoPrazoWS();
            var R = new ws.correios.precos.cResultado();

            // R = C.CalcPrecoPrazo("6092160", "00303128", "41068", "04675085", "48400000", 6, 1, 50, 18, 33, 0, "N", 0, "N")

            string lMaosProprias = Dados.MaosProprias ? "S" : "N";
            string lAviso = Dados.AvisoDeRecebimento ? "S" : "N";
            string lCodigo = Dados.ServicoPadrao == ConsultaDePreco.cTipoServico.c00000UsarOutroCodigo ? Dados.ServicoCodigo : System.Convert.ToString(Dados.ServicoPadrao);
            
            // realiza a consulta
            await Task.Run(()=>
            {

                try
                {

                    // tempo
                    C.Timeout = Dados.TempoServidor;

                    // calcula
                    R = C.CalcPrecoPrazo(Dados.CodigoEmpresa,
                        Dados.Senha, lCodigo, Dados.CepOrigem, Dados.CepDestino,
                        Dados.Peso.ToString(), (int)Dados.Formato,
                        Dados.Comprimento, Dados.Altura, Dados.Largura, Dados.Diametro,
                        lMaosProprias, Dados.ValorDeclarado, lAviso);

                    // copia os dados
                    Resultado.CODIGO = R.Servicos[0].Codigo.ToString();
                    Resultado.ENTREGADOMICILIAR = R.Servicos[0].EntregaDomiciliar;
                    Resultado.ENTREGASABADO = R.Servicos[0].EntregaSabado;
                    Resultado.ERRO = R.Servicos[0].Erro;
                    Resultado.MSGERRO = R.Servicos[0].MsgErro;
                    Resultado.PRAZOENTREGA = R.Servicos[0].PrazoEntrega;
                    Resultado.VALOR = R.Servicos[0].Valor;
                    Resultado.VALORAVISORECEBIMENTO = R.Servicos[0].ValorAvisoRecebimento;
                    Resultado.VALORMAOPROPRIA = R.Servicos[0].ValorMaoPropria;
                    Resultado.VALORVALORDECLARADO = R.Servicos[0].ValorValorDeclarado;

                }
                catch (Exception ex)
                {
                    Resultado.MSGERRO = ex.Message;
                }

            });

            return Resultado;

        }

        public async Task<Envelope> Consultar_ObjetoAsync(string Objeto, string Usuario, string Senha, string Tipo = "T", string Resultado = "L")
        {

            var client = new ws.correios.rastro.ServiceClient();
            var requestInterceptor = new CorreioWebService.InspectorBehavior();
            var Dados = new Envelope();
            string arquivo_temp = @"c:\gearlive\temp\" + DateTime.Now.ToString("yyyy-MM-dd HHmmss") + "_" + Objeto + ".xml";

            client.Endpoint.Behaviors.Add(requestInterceptor);

            //limpa
            Mensagem = "";

            await Task.Run(() =>
            {

                try
                {

                    // realiza consulta no correio               
                    client.buscaEventos(Usuario, Senha, Tipo, Resultado, "101", Objeto);

                    //salva o arquivo da consulta
                    System.IO.File.WriteAllText(arquivo_temp, requestInterceptor.LastResponseXML);

                    XmlSerializer ser = new XmlSerializer(typeof(Envelope));
                    TextReader textReader = (TextReader)new StreamReader(arquivo_temp);
                    XmlTextReader reader = new XmlTextReader(textReader);
                    reader.Read();

                    Dados = (Envelope)ser.Deserialize(reader);

                    reader.Close();

                }
                catch (Exception ex)
                {
                    Mensagem = ex.Message;
                }

            });

            return Dados;

        }

        public void TEste(string xml)
        {

            System.IO.File.WriteAllText(@"c:\gearlive\temp\consulta.xml", xml);

            XmlSerializer ser = new XmlSerializer(typeof(Envelope));
            TextReader textReader = (TextReader)new StreamReader(@"c:\gearlive\temp\consulta.xml");
            XmlTextReader reader = new XmlTextReader(textReader);
            reader.Read();

            Envelope nota = (Envelope)ser.Deserialize(reader);

        }

    }

}
