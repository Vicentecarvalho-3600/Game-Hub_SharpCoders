

namespace GameHub_SharpCoders.models;
public class Pessoa {

    public string Name;
    public int Vitorias { get; set; }
    public int Derrotas { get; set; }
    public int Empate { get; set; }


    public Pessoa(string nome) {
        Name = nome;
        
    }
}

