using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHub_SharpCoders.models;
public class BatalhaNaval {

    private int num1;
    private int num2;
    private string[,] tabela = new string[8, 8];
    private int Tentativas = 0;
    private int Coluna;
    private int Linha;
    public int QuantidadeBarcos = 0;
    private string AguaOuBomba = "";


    Random rnd = new Random();

    public BatalhaNaval() {

        for (int i = 0; i < 2; i++) {
            num1 = rnd.Next(8);
            num2 = rnd.Next(8);

            tabela[num1, num2] = "N";
        }

        for (int i = 0; i <= 7; i++) {
            for (int j = 0; j <= 7; j++) {
                if (tabela[i, j] == "N") {
                    QuantidadeBarcos++;
                }
            }
        }
    }

    public void Apresentar() {
        Console.Clear();
        for (int i = 0; i <= 7; i++) {
            for (int j = 0; j <= 7; j++) {
                if (tabela[i, j] == "N" || tabela[i, j] == "B") {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"|{tabela[i, j]}|");
                    Console.ResetColor();
                }
                else if (tabela[i, j] == "A") {

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write($"|{tabela[i, j]}|");
                    Console.ResetColor();
                }
                else {
                    Console.Write($"|*|");
                }
            }
            Console.WriteLine();

        }
        Console.WriteLine($"------{AguaOuBomba}------\n ------Faltam {QuantidadeBarcos} submarinos------");
    }

    public void SelecionarCasa(int coluna, int linha) {
        Coluna = coluna;
        Coluna--;    
        Linha = linha;
        Linha--;
        Tentativas++;
        
        if (tabela[Linha, Coluna] == "N") {
            QuantidadeBarcos--;
            //Console.WriteLine($"------BOMBA------\n ------Faltam {QuantidadeBarcos} submarinos------");
            tabela[Linha, Coluna] = "B";
            AguaOuBomba = "BOMBA";
            Console.Beep();
        }
        else {
            tabela[Linha, Coluna] = "A";
            //Console.WriteLine($"------AGUA------\n ------Faltam {QuantidadeBarcos} submarinos------");
            AguaOuBomba = "AGUA";
        }
    }

    public void ImprimeVitoria() {
        Console.WriteLine("---------------------------------------------------------------------------");
        Console.WriteLine("-------------------------------Parabéns------------------------------------");
        Console.WriteLine("---------------------------------------------------------------------------");
        Console.WriteLine($"-----------------------------Tentativas: {Tentativas}--------------------------------");

    }

}

