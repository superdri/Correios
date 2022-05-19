using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Correios
{

    public partial class ForCorreios : Form
    {

        public ForCorreios()
        {
            InitializeComponent();
        }

        private async void cmdConsultarObj_Click(object sender, EventArgs e)
        {
            
            var C = new Correio();
            var lst = new ListViewItem();

            txtObj.Enabled = false;
            cmdConsultarObj.Enabled = false;

            //limpa
            lstObj.Items.Clear();

            var r = await C.Consultar_ObjetoAsync(txtObj.Text, txtUsuario.Text, txtSenha.Text);

            if (C.Mensagem != "")
            {
                MessageBox.Show(C.Mensagem);
            }
            else
            {
                
                foreach (returnObjetoEvento evento in r.Body.buscaEventosResponse.@return.objeto.evento)
                {

                    lst = lstObj.Items.Add(r.Body.buscaEventosResponse.@return.objeto.categoria);
                    lst.SubItems.Add(r.Body.buscaEventosResponse.@return.objeto.numero);
                    lst.SubItems.Add(evento.data + " " + evento.hora);
                    lst.SubItems.Add(evento.descricao);
                    lst.SubItems.Add(evento.local);
                    lst.SubItems.Add(evento.uf + " " + evento.cidade);
                    lst.SubItems.Add(evento.tipo);  
                    
                    if (evento.endereco != null)
                    {

                        string local = evento.endereco.logradouro + " " + 
                            evento.endereco.numero + " " +
                            evento.endereco.bairro + " " + 
                            evento.endereco.localidade;

                        lst.SubItems.Add(local);

                    }

                }

                //salva
                Microsoft.VisualBasic.Interaction.SaveSetting("DemoCorreios", "Config", "ConsultaDeObjetoUsuario", txtUsuario.Text);
                Microsoft.VisualBasic.Interaction.SaveSetting("DemoCorreios", "Config", "ConsultaDeObjetoSenha", txtSenha.Text);

            }

            txtObj.Enabled = true;
            cmdConsultarObj.Enabled = true;

        }

        private void ForCorreios_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = Microsoft.VisualBasic.Interaction.GetSetting("DemoCorreios", "Config", "ConsultaDeObjetoUsuario", "");
            txtSenha.Text   = Microsoft.VisualBasic.Interaction.GetSetting("DemoCorreios", "Config", "ConsultaDeObjetoSenha", "");
        }

    }

}
