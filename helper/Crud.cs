﻿using System.Text.Json;
using GameHub_SharpCoders.models;
using Newtonsoft.Json;

namespace GameHub_SharpCoders.helper;
public class Crud {

    public string ArquivoJson = @"C:\temp\GameHub-SharpCoders\GameHub-SharpCoders\arquivosbancoDeDados.json";
    
    public void RegistarNovoUsuario(string nome) {
        Pessoa novoUsuario = new Pessoa(nome);
        string jsonString = JsonConvert.SerializeObject(novoUsuario, Formatting.Indented);
        File.WriteAllText(ArquivoJson, jsonString);
        
    }

    public void ListaUsuarios() {

    }

}

