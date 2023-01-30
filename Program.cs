using GameHub_SharpCoders.helper;
using GameHub_SharpCoders.models;
using GameHub_SharpCoders.view;
using Newtonsoft.Json;

namespace GameHub;
public class Program {
    static void Main(string[] args) {

        /*
        jogo.MostrarCampo();

        jogo.AdicionarJogador("ana");
        jogo.AdicionarJogador("vicente");

        jogo.ListaJogadores();
        */

        Crud dados= new Crud();

        dados.RegistarNovoUsuario("Vicente", "123456");
        dados.RegistarNovoUsuario("Ana", "123456");

    }
}