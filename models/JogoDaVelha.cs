using GameHub_SharpCoders.view;

namespace GameHub_SharpCoders.models;
public class JogoDaVelha  {

    private string[,] matriz = new string[3, 3];
    private string turno = "X";
    public int tentativas = 0;


    // adcionada os valores de 1 a 9 na matriz
    public JogoDaVelha() {
        int index = 1;
        for (int i = 0; i < matriz.GetLength(0); i++) {
            for (int j = 0; j < matriz.GetLength(1); j++) {
                matriz[i, j] = index.ToString();
                index++;
            }
        }

    }

    // funcao para apresentar como esta o jogo
    public void Apresentar() {
        for (int i = 0; i < matriz.GetLength(0); i++) {
            for (int j = 0; j < matriz.GetLength(1); j++) {
                Console.Write($"|{matriz[i, j]}|");
            }
            Console.WriteLine();
        }
    }

    // adcionada X ou O na sua devida casa de acordo com numero
    public void SelecionarCasa(string numero) {
        string valor = numero;
        bool eNumero = int.TryParse(valor, out int casa);
        switch (casa) {
            case 1:
                matriz[0, 0] = turno;
                break;
            case 2:
                matriz[0, 1] = turno;
                break;
            case 3:
                matriz[0, 2] = turno;
                break;
            case 4:
                matriz[1, 0] = turno;
                break;
            case 5:
                matriz[1, 1] = turno;
                break;
            case 6:
                matriz[1, 2] = turno;
                break;
            case 7:
                matriz[2, 0] = turno;
                break;
            case 8:
                matriz[2, 1] = turno;
                break;
            case 9:
                matriz[2, 2] = turno;
                break;
            default:
                Console.WriteLine("casa invalida");
                break;
        }
    }

    // faz a alternacia de valores X ou O
    public void AlternarTurno() {
        if (turno == "X") {
            turno = "O";
        }
        else {
            turno = "X";
        }
    }

    // incrementa o valor de tentativas
    public void Rodadas() {
        tentativas++;
        AlternarTurno();
    }


    public bool VerificarvalorDaCasa(string numero) {
        string valor = numero;
        bool eNumero = int.TryParse(valor, out int casa);
        if (casa > 9 || casa < 1) {
            return true;
        }
        else if (eNumero) {
            return false;
        }
        else {
            return false;
        }
    }

    public string TurnoAtual() {
        return turno;
    }

    public void ImprimirGanhador() {
        Console.WriteLine($"O jogador {turno} ganhou");
    }


    public void VerificarCondicaoDeVitoria() {
        if (matriz[0, 0] == matriz[1, 1] && matriz[1, 1] == matriz[2, 2] ||
             matriz[0, 2] == matriz[1, 1] && matriz[1, 1] == matriz[2, 0]) {
            ImprimirGanhador();
            tentativas = 10;
        }
        else if (
                matriz[0, 0] == matriz[0, 1] && matriz[0, 1] == matriz[0, 2] ||
                matriz[1, 0] == matriz[1, 1] && matriz[1, 1] == matriz[1, 2] ||
                matriz[2, 0] == matriz[2, 1] && matriz[2, 1] == matriz[2, 2]) {
            ImprimirGanhador();
            tentativas = 10;
        }
        else if (
                matriz[0, 0] == matriz[1, 0] && matriz[1, 0] == matriz[2, 0] ||
                matriz[0, 1] == matriz[1, 1] && matriz[1, 1] == matriz[2, 1] ||
                matriz[0, 2] == matriz[1, 2] && matriz[1, 2] == matriz[2, 2]) {
            ImprimirGanhador();
            tentativas = 10;
        }
        else if (tentativas == 8) {
            Console.WriteLine("empate ninguem ganhou");
        }

    }

}

