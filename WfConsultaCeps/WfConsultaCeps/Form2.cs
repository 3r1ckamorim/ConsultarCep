using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WfConsultaCeps
{
    public partial class Form2 : Form
    {
        public string Endereco
        {
            get { return txtEndereco.Text; }
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {


                //criando uma variavel do ws dos correios
                var webService = new WsCorreios.AtendeClienteClient();
                //ezecurtando o metodo que consulta o Cep
                //parametro = string cep
                var res = webService.consultaCEP(txtCep.Text);

                txtEndereco.Text = res.end;
                txtBairro.Text = res.bairro;
                txtComplemento.Text = res.complemento2;
                txtCidade.Text = res.cidade;
                txtEstado.Text = res.uf;
                txtComplemento2.Text = res.complemento2;

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
