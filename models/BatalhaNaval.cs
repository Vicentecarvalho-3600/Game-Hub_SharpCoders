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
    private int QuantidadeBarcos = 0;


    Random rnd = new Random();

    public BatalhaNaval() {

        for (int i = 0; i < 20; i++) {
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
    }

    public void SelecionarCasa(int coluna, int linha) {
        // Console.WriteLine("Introduza a coluna:(1 ao 8)");
        Coluna = coluna;
        Coluna--;
        // Console.WriteLine("Introduza a linha:(1 ao 8)");
        Linha = linha;
        Linha--;
        Tentativas++;

        if (tabela[Linha, Coluna] == "N") {
            QuantidadeBarcos--;
            Console.WriteLine($"------BOMBA------\n ------Faltam {QuantidadeBarcos} submarinos------");
            tabela[Linha, Coluna] = "B";
            Console.Beep();
        }
        else {
            tabela[Linha, Coluna] = "A";
            Console.WriteLine($"------AGUA------\n ------Faltam {QuantidadeBarcos} submarinos------");
        }
    }

    public void ImprimeVitoria() {
        Console.WriteLine("---------------------------------------------------------------------------");
        Console.WriteLine("-------------------------------Parabéns------------------------------------");
        Console.WriteLine("---------------------------------------------------------------------------");
        Console.WriteLine($"-----------------------------Tentativas: {Tentativas}--------------------------------");

    }

}

