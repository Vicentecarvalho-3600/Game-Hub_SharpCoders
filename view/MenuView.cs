
namespace GameHub_SharpCoders.view;
public class MenuView {
    
    public void BemVindo() {
        Console.WriteLine("****************************************");
        Console.WriteLine("*          Bem Vindo GameHub           *");
        Console.WriteLine("****************************************");
    }

    public void ShowMenu() {
        Console.Clear();
        Console.WriteLine("[1] - Jogo da Velha");
        Console.WriteLine("[2] - Batalha naval");
        Console.WriteLine("[3] - Ranking de Jogadoes");
        Console.WriteLine("[4] - Cadastro de Jogadores");
        Console.Write("Digite a opção desejada: ");
    }
} 

