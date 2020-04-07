using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIMV
{
    class Program
    {
        static void Main(string[] args)
        {
            ReservarItem();
        }
        static void ReservarItem() 
        {

           SelecionarMaisEquipamentos:

            List<string> equipamentos = new List<string>();
            equipamentos.Add("DATA-SHOWS");
            equipamentos.Add("TV com VCR");
            equipamentos.Add("TV com DVD");
            equipamentos.Add("Projetor de Slides");
            equipamentos.Add("Sistemas de ÁudioMicrofone");
            equipamentos.Add("Caixa Amplificada");
            equipamentos.Add("Notebooks");
            equipamentos.Add("Kits Multimídia");

            foreach (string equips in equipamentos) 
            {
                Console.WriteLine("Item selecionado: {0}", equips);
            }

            //calendario string
            string[] calendarioDias = new string[32];

            NovaSeleçãoDeData:

            Console.WriteLine("Digite o dia da reserva: ");
            int diaDaReserva = new int();
            diaDaReserva = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número da sala desejada: ");
            int SaladeAula = new int();
            SaladeAula = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Horario: ");
            int horarioDaReserva = new int();
            horarioDaReserva = int.Parse(Console.ReadLine());

            int InfoDatasReserva = new int();
            InfoDatasReserva = diaDaReserva + horarioDaReserva ; 

            if (calendarioDias[] = true)//parametro deve comparar se as datas  se for verdadeiro então esta preenchido e devera selecionar um novo dia
            {
                Console.WriteLine("Este equipamento já se encontra reservado nesta data e horário, selecione uma nova data.");
                goto NovaSeleçãoDeData;
            }
            else 
            {
                Console.WriteLine("Gostaria de selecionar mais itens para sua reserva? (s / n)");
                char seletorOpcao = ' ';
                if (seletorOpcao == 's' || seletorOpcao == 'S') 
                {
                    goto SelecionarMaisEquipamentos;
                }
                else 
                {
                    Console.WriteLine("Reserva efetuada com sucesso! \n Itens reservados para dia {0}, ás {0} horas na sala {0}", diaDaReserva, horarioDaReserva, SaladeAula);
                }

                
            }
        }
    }
}
