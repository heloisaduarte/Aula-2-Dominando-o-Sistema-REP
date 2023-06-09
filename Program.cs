﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Informe Seu Nome:");
var nome = Console.ReadLine();

Console.WriteLine("Hello," + nome);
Console.WriteLine($"Hello, {nome}");

//var umaString = "Jornada .NET";
var numeroInt = 5;
//var numeroFloat = 5.4f;
//var numeroDouble = 5.4;
//var numeroDecimal = 5.4m;
//var caractere = 'a';
var data = new DateTime(1992, 1, 1);
var agora = DateTime.Now;

Console.WriteLine(agora);

Console.WriteLine("Digite uma opção entre 1 e 3");

var opcao = Console.ReadLine();

//Estrutura de condição

Console.WriteLine("Com  If");
if(opcao == "1"){
    Console.WriteLine("Opção 1 selecionada.");
}else if(opcao == "2"){
    Console.WriteLine("Opção 2 selecionada.");
}else if(opcao == "3"){
    Console.WriteLine("Opção 3 selecionada.");
}else{
    Console.WriteLine("Opção inválida");
}

// ternário
var opcaoE3 = opcao =="3"? "Sim" : "Não";

Console.WriteLine("Com Switch");
switch(opcao){
    case "1" :
        Console.WriteLine("Opção 1 selecionada.");
        break;
    case "2" :
        Console.WriteLine("Opção 2 selecionada.");
        break;
    case "3" :
        Console.WriteLine("Opção 3 selecionada.");
        break;
    default: 
        Console.WriteLine("Opção inválida");
        break;
}

//Estrutura de repetição

var valores = "0 1 2 3 4 5";
var numeros = valores.Split(' '); // Criar um array

Console.WriteLine("Repetição com For");
for(var i = 0; i < numeros.Length; i++){
    Console.Write(numeros[i]);
}

Console.WriteLine();

var contador = 0;

Console.WriteLine("Com While");

while(contador < numeros.Length){
    Console.Write(numeros[contador]);
    contador++;
}

Console.WriteLine();

do{
    Console.WriteLine("Executando com do-while");
} while(numeroInt == 3);


Console.WriteLine("Executando Com Foreach");
foreach(var numero in numeros){
    Console.WriteLine(numero);
}

//Estruturas de dados

//Matrizes e Listas

var matriz = new int[5]{0, 1, 2, 3 ,4};

 var matrizV2 = new int[5];

 matrizV2[0] = 0;
 matrizV2[1] = 1;
 matrizV2[2] = 2;
 matrizV2[3] = 3;
 matrizV2[4] = 4;

 Console.WriteLine(matrizV2[3]);

 var lista = new List<int>{0, 1, 2, 3 ,4};
 var listaV2 = new List<int>();
 listaV2.Add(0);
 listaV2.Add(1);
 listaV2.Add(2);
 listaV2.Add(3);
 listaV2.Add(4);

 var maiorQue2 = lista.Where(n => n > 2);

 foreach(var numero in maiorQue2){
    Console.WriteLine(numero);
 }
 var soma = lista.Sum();
 var media = lista.Average();
 var max = lista.Max();
 var min = lista.Min();

 Console.WriteLine($"Soma: {soma}");
 Console.WriteLine($"Media: {media}");
 Console.WriteLine($"Max: {max}");
 Console.WriteLine($"Min: {min}");
 
 //Dicionarios
 var dicionario = new Dictionary<int, string>(){
    {0, "zero"},
    {1, "um"},
    {2, "dois"},
    {3, "três"},
    {4, "quatro"},
 };
var dicionarioV2 = new Dictionary<int, string>{
    [0] = "zero",   
    [1] = "um",  
    [2] = "dois",  
    [3] = "três",  
    [4] = "quatro"  
};

var dicionarioV3 = new Dictionary<int, string>();
    dicionarioV3.Add(0, "zero");
    dicionarioV3.Add(1, "um");
    dicionarioV3.Add(2, "dois");
    dicionarioV3.Add(3, "tres");
    dicionarioV3.Add(4, "quatro");

Console.WriteLine(dicionario[0]);
Console.WriteLine(dicionarioV2[1]);
Console.WriteLine(dicionarioV3[2]);

//Programação Orientada a Objetos

//Criando Classe

var evento = new Evento(1, "Jornada .NET", "Um evento incrível", DateTime.Now, DateTime.Now.AddDays(7), "Luis Dev");

var show = new Show("LuisDev" ,"Musicas A, B e C" ,1, "Jornada .NET", "Um evento incrível", DateTime.Now, DateTime.Now.AddHours(4), "Luis Dev");

//Polimorfismo
var eventos = new List<Evento>{evento, show};

foreach(var item in eventos){
    Console.WriteLine(item.GerarResumo());
}

public class Evento{
    // construtor
    public Evento(int id, string titulo, string descricao, DateTime dataInicio, DateTime dataFim, string organizador)
    {
        Id = id;
        Titulo = titulo;
        Descricao = descricao;
        DataInicio = dataInicio;
        DataFim = dataFim;
        Organizador = organizador;
    }

    public int Id { get; private set; }
    public string Titulo { get; private set; }
    public string Descricao { get; private set; }     
    public DateTime DataInicio { get; private set; }
    public DateTime DataFim { get; private set; }
    public string Organizador { get; private set; }

    //Abstração
    //polimorfismo
    public virtual string GerarResumo(){
        return $"Evento {Titulo}, {DataInicio} - {DataFim}, {Organizador}";
    }
}

//HERANCA
public class Show : Evento
{
    public Show(string artista, string tracklist, int id, string titulo, string descricao, DateTime dataInicio, DateTime dataFim, string organizador) : base(id, titulo, descricao, dataInicio, dataFim, organizador)
    {
        Artista = artista;
        Tracklist = tracklist;
    }

    public string Artista { get; private set; }
    public string Tracklist  { get; private set; }

    //sobrescreve o método da classe mae
    public override string GerarResumo()
    {
        var resumoBase = base.GerarResumo();

        return $"{resumoBase}, {Artista}, {Tracklist}";
    }
}