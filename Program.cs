using GameHub_SharpCoders.models;
using GameHub_SharpCoders.view;
using Newtonsoft.Json;
using System.Diagnostics;

namespace GameHub;
public class Program {
    static void Main(string[] args) {

        int option;
        

        do {
            MenuView.BemVindo();
            MenuView.ShowMenu();
            Console.Write("Selecione um opção: ");
            option = int.Parse(Console.ReadLine());

            switch(option){
                case 0:
                    Console.WriteLine();
                    break;
                case 1:
                    JogoDaVelha jogoDaVelha = new JogoDaVelha();
                    do {
                        Console.Clear();
                        jogoDaVelha.Apresentar();
                        Console.WriteLine($"Rodada {jogoDaVelha.tentativas + 1}º vez {jogoDaVelha.TurnoAtual()}");
                        Console.WriteLine("selecione uma casa de 1 a 9");
                        string casa = (Console.ReadLine());
                        while (jogoDaVelha.VerificarvalorDaCasa(casa)) {
                            Console.WriteLine("Valor invalido digite novamente!!");
                            casa = Console.ReadLine();
                        }
                        jogoDaVelha.SelecionarCasa(casa);
                        jogoDaVelha.VerificarCondicaoDeVitoria();
                        jogoDaVelha.Rodadas();

                    } while (jogoDaVelha.tentativas < 9);
                    Console.Write("Pressine Tecla Para Sair: ");
                    Console.ReadKey();
                    break;
                case 2:
                    BatalhaNaval batalhaNaval = new BatalhaNaval();
                    do {
                        batalhaNaval.Apresentar();
                        Console.Write("Selecione Coluna: ");
                        int coluna = int.Parse(Console.ReadLine());
                        Console.Write("Selecione Linha: ");
                        int linha = int.Parse(Console.ReadLine());
                        batalhaNaval.SelecionarCasa(coluna, linha);
                    } while (batalhaNaval.QuantidadeBarcos > 0);
                    batalhaNaval.ImprimeVitoria();
                    Console.Write("Pressine Tecla Para Sair: ");
                    Console.ReadKey();
                    break;
            }
        

        } while(option != 0);

    }
}