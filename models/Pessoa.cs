

namespace GameHub_SharpCoders.models;
public class Pessoa {

    public string Name { get; set; }
    public string Senha { get; set; }
    public int Vitorias { get; set; }
    public int Derrotas { get; set; }
    public int Empate { get; set; }


    public Pessoa(string nome, string senha) {
        Name = nome;
        Senha = senha;
    }
}

