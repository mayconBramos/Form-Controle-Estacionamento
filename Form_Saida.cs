using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Desafio_Garagem
{
    public partial class Form_Saida : Form
    {
        public Form_Saida()
        {


        }
        // construtor para ter acesso as informações do form_garagem
        public Form_Saida(string placa, string permanencia, string valor)
        {
            InitializeComponent();
            //mostra a placa 
            tbx_Placa1.Text = placa;

            //mostra tempo de permanencia
            tbx_Permanencia.Text = permanencia;

            //mostra o valor a ser pago
            tbx_Valor_Pago.Text = valor;

        }

        // açõoes ao clicar no botão ok
        private void btn_Ok_Click(object sender, EventArgs e)
        {
            // fecha a caixa form_Saida, mantendo a principal aberta
           Close();
        }
    }
}
