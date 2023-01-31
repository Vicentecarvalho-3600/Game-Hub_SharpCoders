
using GameHub_SharpCoders.models;

namespace GameHub_SharpCoders.view;
public class MenuView {
    
    public static void BemVindo() {
        Console.Clear();
        Console.WriteLine("****************************************");
        Console.WriteLine("*          Bem Vindo GameHub           *");
        Console.WriteLine("****************************************");
    }

    public static void ShowMenu() {
        
        Console.WriteLine("[1] - Jogo da Velha");
        Console.WriteLine("[2] - Batalha naval");
        
        //Console.WriteLine("[4] - Cadastro de Jogadores "); // NÃO IMPLENTADO
        
    }

    public static void RankJogadores(List<Pessoa> jogadores) {
        Console.WriteLine("________lista jogadores________");

        foreach(var jogador in jogadores) {
            Console.WriteLine($"Nome: {jogador.Name} Vitorias: {jogador.Vitorias} Derrotas: {jogador.Derrotas} Empates: {jogador.Empate}");
        }
    }
} 

