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
    public partial class Form_Garagem : Form
    {
        public Form_Garagem()
        {
            InitializeComponent();
        }

        // criando lista entrada
        List<Veiculos> lista_Entrada = new List<Veiculos>();

        // criando lista saida
        List<Veiculos> lista_Saida = new List<Veiculos>();

        //timer que faz o relogio se atualizar na tela
        private void timer1_Tick(object sender, EventArgs e)
        {
            hora_Principal.Value = DateTime.Now;
        }

        // ações ao apertar botão entrada
        private void brn_Entrada_Click(object sender, EventArgs e)
        {
            // declarando variavel para melhor identificação
            bool placa_Valida = Veiculos.Validar_Placa(tbx_Placa.Text);

            // validar caracteres placa
            if (placa_Valida != true)
            {
                MessageBox.Show("Placa inválida!", "Atenção");
            }
            else
            {
                // declarando variavel para melhor identificação
                int localizar = Veiculos.Localizar(tbx_Placa.Text, lista_Entrada);

                // verificar se placa ja esta cadastrada
                if (localizar != -27)
                {
                    MessageBox.Show("Veiculo ja cadastrado!", "Atenção");
                }
                else
                {
                    // verificar se tem lugar na garagem
                    if (Veiculos.Vagas(lista_Entrada, 50) != true)
                    {
                        MessageBox.Show("Garagem Lotada!", "Atenção");
                    }
                    else
                    {
                        //cria veiculo
                        Veiculos veiculos = new Veiculos(tbx_Placa.Text, data_Principal.Text, hora_Principal.Text);

                        //adiciona na lista entrada
                        lista_Entrada.Add(veiculos);

                        //mostra na lista entrada
                        dataGrid_Garagem.Rows.Add(veiculos.Placa, veiculos.Data, veiculos.Hora_Entrada);

                        //grava no arquivo entrada
                        Persistencia.gravarNoArquivoEntrada(lista_Entrada);

                    }
                }
            }
        }

        // ações ao apertar botão saida
        private void btn_Saida_Click(object sender, EventArgs e)
        {
            
            // declarando variavel para melhor identificação
            string hora_Saida = hora_Principal.Text;

            //procurar placa na lista entrada
            int indice = Veiculos.Localizar(tbx_Placa.Text, lista_Entrada);

            // validação para caso a placa não exista na lista entrada
            if(indice == 27)
            {
                MessageBox.Show("Veiculo não esta na garagem!", "Atenção");
            }
            else
            {
                
                if (indice < 0)
                {
                    MessageBox.Show("Veiculo não encontrado");
                }
                else
                {

                    // criar veiculo com o indice da placa digitada
                    Veiculos veiculo = lista_Entrada[indice];
                    
                    //chamando método Tempo_Garagem
                    int permanencia = veiculo.Tempo_Garagem(veiculo.Hora_Entrada, hora_Saida);

                    // realizando cobrança do valor
                    string cobranca = veiculo.Cobranca((int)NumUp_Valor_Hora.Value, permanencia).ToString("C");

                    veiculo = new Veiculos(veiculo.Placa, veiculo.Data, veiculo.Hora_Entrada, hora_Principal.Text, permanencia, cobranca);

                    //Mostra em destaque para confirmar saida
                    var form_saida = new Form_Saida(veiculo.Placa,permanencia.ToString(),cobranca);

                    form_saida.Show();
                    
                    //adicionar na lista saida
                    lista_Saida.Add(veiculo);

                    //mostra na lista saida
                    dataGrid_Saida.Rows.Add(veiculo.Placa, veiculo.Data, veiculo.Hora_Entrada, veiculo.Hora_Saida,
                                            veiculo.Permanencia, veiculo.Valor);

                    //apagar da lista entrada
                    lista_Entrada.RemoveAt(indice);

                    //apagar da tela entrada
                    dataGrid_Garagem.Rows.RemoveAt(indice);

                    //atualizar lista
                    Persistencia.gravarNoArquivoEntrada(lista_Entrada);

                    //grava no arquivo saida
                    Persistencia.gravarNoArquivoSaida(lista_Saida);
                    
                }
            }
        }
    }          
}
