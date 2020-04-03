using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaDeReserva
{
    class Reserva
    {

        public void ReservaItens()
        {

        MesSelecionado:
            int DataMes;
            int MesNum = 0;
            Console.WriteLine("Selecione o mês da reserva");
            Console.WriteLine("2 - Fevereiro / 3 - Março / 4 - Abril / 5 - Maio / 6 - Junho / 0 - Sair ");
            DataMes = int.Parse(Console.ReadLine());

            //inserir while


            switch (DataMes)
            {

                case '2':
                    MesNum = 02;
                    Console.WriteLine("Fevereiro");
                    break;

                case '3':
                    MesNum = 03;
                    Console.WriteLine("Março");
                    break;

                case '4':
                    MesNum = 04;
                    Console.WriteLine("Abril");
                    break;

                case '5':
                    MesNum = 05;
                    Console.WriteLine("Maio");
                    break;

                case '6':
                    MesNum = 06;
                    Console.WriteLine("Junho");
                    break;

                case '0':
                    DataMes = 0;
                    break;

            }

            //Pergunta se a data do mÊs esta correta

            Console.WriteLine("Você Selecionou o mês de ", MesNum, "Gostaria de alterar o mêes selecionado [s/n]?");
            if (DataMes == 's' || DataMes == 'S')
            {
                goto MesSelecionado;
            }
            else
            {

                int DataDia;

                Console.WriteLine("Selecione o dia da reserva");
                DataDia = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Reserva para o dia ", DataDia, "/", MesNum);
            }

            //------------------------------------------------------------------------------------------------------


            public lista(string[] args)
            {

                //lista de itens a serem reservados

                string[] equipamento = new string[9];
                

                equipamento[0] = "Selecione o item a ser reservado";
                equipamento[1] = "1 - Datashow";
                equipamento[2] = "2 - TV com VCR";
                equipamento[3] = "3 - TV com DVD";
                equipamento[4] = "4 - Projeto de Slides";
                equipamento[5] = "5 - Sistema de Audio - microfone";
                equipamento[6] = "6 - Caixa Amplificadora";
                equipamento[7] = "7 - Notebook";
                equipamento[8] = "8 - Kit Multimídia";


                Console.WriteLine(equipamento.Length);

            SelecionarEquipamento:
                int seletor = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Você selecionou o item para reserva", equipamento[seletor], "Gostaria de adicionar mais itens? (s/n)");

                int AddItens = 0;
                //Socoro já não sei mais o que estou fazendo
               // int ItensTotal = equipamento[] + equipamento[];
                AddItens = int.Parse(Console.ReadLine());

                
                if (AddItens == 's' || AddItens == 'S')
                {
                    goto SelecionarEquipamento;
                }

                else
                {
                    //mostrar os dados da reserva
                }
                

                //criar submenu com as opções de equipamento de video, audio, multimidia ou todos

                //for para video do 1 ao 4
                //for (int i=1; i>=4; i++)  {  }

                //for para audio do 5 ao 6
                //for (int i=5; i>=6; i++)  {  }

                //for para multimidia 7 e 8
                //for (int i=7; i>=8; i++)  {  }

                // para todos os itens 1>=8
                //foreach (int totalList in equipamento)  
                //{  
                //    Console.WriteLine(totalList);
                //}

            }
        }
    }
}