using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Desafio_Garagem
{
    internal class Veiculos
    {
        string placa;
        string data;
        string hora_Entrada;
        string hora_Saida;
        int permanencia; 
        string valor;

        // construtor é utilizado na leitura do arquivo de veículos que estão na garagem
        public Veiculos(string placa, string dataEntrada, string horaEntrada)
        {
            this.Placa = placa;
            this.Data = dataEntrada;
            this.Hora_Entrada = horaEntrada;
        }

        // construtor capturando somente a placa do veículo
        public Veiculos(string placa)
        {
            this.Placa = placa;
        }

        // construtor é utilizado na leitura do arquivo de saída com veículos que já passaram pela garagem
        public Veiculos(string placa, string data, string hora_Entrada,
            string horaSaida, int tempoPermanecia, string valor) : this(placa, data, hora_Entrada)
        {
            
            this.Hora_Saida = horaSaida;
            this.Permanencia = tempoPermanecia;
            this.Valor = valor;
        }

        // validação de placa
        public static bool Validar_Placa(string placa)
        {
            if (placa.Count() == 7)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        // metodo que descobre se há vagas livres na garagem
        public static bool Vagas(List<Veiculos> lista, int limite_Garagem)
        {
            if (lista.Count < limite_Garagem)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //metodo que procura um veiculo na lista a partir de sua placa
        public static int Localizar(string placa, List<Veiculos> lista)
        {
            foreach (Veiculos i in lista)
            {
                if (i.Placa.Equals(placa))
                {
                    return lista.IndexOf(i);
                }
            }
            return -27; //codigo do ESC, ou seja, veiculo nao localizado
        }

        // metodo que calcula o tempo de permanencia (em minutos)
        public  int Tempo_Garagem(string hora_Entrada, string hora_Saida)
        {
            // preparando a hora entrada para usar o TimeSpan
            string[] entrada_Splitado = hora_Entrada.Split(':');
            int hora = int.Parse(entrada_Splitado[0]);
            int minutos = int.Parse(entrada_Splitado[1]);
            int segundos = int.Parse(entrada_Splitado[2]);

            // preparando a hora saida para usar o TimeSpan
            string[] saida_Splitado = hora_Saida.Split(':');
            int horas_Saida = int.Parse(saida_Splitado[0]);
            int minutos_Saida = int.Parse(saida_Splitado[1]);
            int segundos_Saida = int.Parse(saida_Splitado[2]);

            // passando valores entrada para TimeSpan
            TimeSpan entrada_Minutos = new TimeSpan(hora,minutos,segundos);

            int minutos_Total_Entrada = (int)entrada_Minutos.TotalMinutes;

            // passando valores  saida para TimeSpan
            TimeSpan saida_Minutos = new TimeSpan(horas_Saida, minutos_Saida, segundos_Saida);

            int minutos_Total_Saida = (int)saida_Minutos.TotalMinutes;

            // tempo de permanencia
            int tempo = minutos_Total_Saida - minutos_Total_Entrada;

            return tempo;

        }

        // metodo para realizar cobrança pelo tempo de permanencia
        public  double Cobranca(double valor_Hora, int permanencia)
        {
            // valor inicial
            double valor = 0;

            // declarando variavel horas
            int hrs = (permanencia / 60);

            // declarando variavel minutos
            int min = (permanencia % 60);

           
            // caso a permanencia seja em horas exatas
            if (min == 0)
            {
                //soma do valor
                valor = hrs * valor_Hora;

                return valor;
            }
            else // caso a permanencia tenha minutos extrar para acrescentar mais uma hora no total
            {

                //acrescentando uma hora extra
                hrs += 1;

                // soma do valor
                valor = hrs * valor_Hora;

                return valor;
                
            }
            
        }

        // propriedades
        public string Placa { get => placa; set => placa = value; }
        public string Data { get => data; set => data = value; }
        public string Hora_Entrada { get => hora_Entrada; set => hora_Entrada = value; }
        public string Hora_Saida { get => hora_Saida; set => hora_Saida = value; }
        public int Permanencia { get => permanencia; set => permanencia = value; }
        public string Valor { get => valor; set => valor = value; }

    }
}