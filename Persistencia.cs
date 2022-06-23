using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Desafio_Garagem
{
    internal class Persistencia
    {

        // método que a partir da lista persiste os dados no arquivo dos veículos que estão na garagem
        public static void gravarNoArquivoEntrada(List<Veiculos> lista)
        {
            try
            {
                StreamWriter escritor = new StreamWriter("veiculosEntrada.dat");

                foreach (Veiculos i in lista)
                {
                    escritor.WriteLine(i.Placa + ";" + i.Data + ";" + i.Hora_Entrada);
                    escritor.Flush();
                }
                escritor.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao gravar arquivo de entrada" + e.Message);
          
            }
           
        }

        // método que a partir da lista persiste os dados no arquivo dos veículos que passaram pela garagem
        public static void gravarNoArquivoSaida(List<Veiculos> lista)
        {
            try
            {
                StreamWriter escritor = new StreamWriter("veiculosSaida.dat");

                foreach (Veiculos i in lista)
                {
                    escritor.WriteLine(i.Placa + ";" + i.Data + ";" + i.Hora_Entrada + ";" + i.Hora_Saida + ";" + i.Permanencia + ";" + i.Valor);
                    escritor.Flush();
                }
                escritor.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao gravar arquivo de saida" + e.Message);
                
            }
        }


        // método que popula a lista de veículos de estão na garagem a partir do arquivo base
        public static void lerArquivoEntrada(List<Veiculos> lista)
        {
            try
            {
                StreamReader leitor = new StreamReader("veiculosEntrada.dat");
                string linha;
                string[] vetorDados;

                do
                {
                    linha = leitor.ReadLine();
                    vetorDados = linha.Split(';');
                    lista.Add(new Veiculos(vetorDados[0], vetorDados[1], vetorDados[2]));
                } while (!leitor.EndOfStream);

                leitor.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show("Erro ao ler arquivo de entrada" + e.Message);

            }

        }


        // método que popula a lista de veículos de passaram pela garagem a partir do arquivo base
        public static void lerArquivoSaida(List<Veiculos> lista)
        {
            try
            {
                StreamReader leitor = new StreamReader("veiculosSaida.dat");
                string linha;
                string[] vetorDados;

                do
                {
                    linha = leitor.ReadLine();
                    vetorDados = linha.Split(';');
                    lista.Add(new Veiculos(vetorDados[0], vetorDados[1], vetorDados[2],
                        vetorDados[4], int.Parse(vetorDados[5]), (vetorDados[6])));
                } while (!leitor.EndOfStream);

                leitor.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao ler arquivo de saida" + e.Message);
                
            }
            
        }
    }
}