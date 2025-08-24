/*
Console.WriteLine("Primeiro Programa");

int idade = 33;
Console.WriteLine(idade);
string nomePessoa = "Rafael Almeida";
Console.WriteLine(nomePessoa);
decimal valor = 200.99m;
double valorDouble = 200.99;
float valorFloat = 200.99f;
Console.WriteLine(valor);
Console.WriteLine(valorDouble);
Console.WriteLine(valorFloat);
var idadeNova = 34;
char flag = 'Y';
Console.WriteLine(flag);
bool ativo = true;
ativo = false;
Console.WriteLine(ativo);

const string descricao = "Curso CSharp";
Console.WriteLine(descricao);

int numero1 = 1;
var numero2 = 2;

var soma = numero1 + numero2;
Console.WriteLine(soma);

var subtracao = numero2 - numero1;
Console.WriteLine(subtracao);

var multiplicacao = (numero2 * numero1) * 10;
Console.WriteLine(multiplicacao);

var divisao = numero2 / numero1;
Console.WriteLine(divisao);

int numero1 = 1;
int numero2 = 2;

bool igual = numero1 == numero2;
Console.WriteLine(igual);

bool diferente = numero1 != numero2;
Console.WriteLine(diferente);

bool maiorOuIgual = numero1 >= numero2;
Console.WriteLine(maiorOuIgual);

bool maior = numero1 > numero2;
Console.WriteLine(maior);

bool menorOuIgual = numero1 <= numero2;
Console.WriteLine(menorOuIgual);

bool menor = numero1 < numero2;
Console.WriteLine(menor);

int numero1 = 1;
int numero2 = 2;

bool valido = numero2 > numero1 && 6 > 7;
Console.WriteLine(valido);

bool valido2 = numero2 > numero1 || 6 > 7;
Console.WriteLine(valido2);

bool valido3 = !(numero2 > numero1);
Console.WriteLine(valido3);

bool ativo = false;
string status = ativo ? "Cadastro Ativo" : "Cadastro Inativo";
Console.WriteLine(status);

string NomeCompleto()
{
    string primeiroNome = "Rafael";
    string segundoNome = "Almeida";
    return primeiroNome + " " + segundoNome;
}

int SomaValores()
{
    return 8 + 2;
}

void EscreverNome()
{
    var nome = NomeCompleto();
    Console.WriteLine(nome);

    var soma = SomaValores();
    Console.WriteLine(soma);
}

EscreverNome();

var soma = SomaValores(3, 5);
Console.WriteLine(soma);

var nome = NomeEIdade("Rafael", 33);
Console.WriteLine(nome);

int SomaValores(int a, int b)
{
    return a + b;
}

string NomeEIdade(string nome, int idade)
{
    return "Meu nome é " + nome + " e tenho " + idade + " anos";
}

using System.Collections;

var arrayList = new ArrayList();
arrayList.Add(1);
arrayList.Add("Rafael");
arrayList.Add(true);

// Console.WriteLine(arrayList[1]);

arrayList.RemoveAt(1);

// arrayList = new ArrayList();
arrayList.Clear();

foreach (var item in arrayList)
{
    Console.WriteLine(item);
}

// var arrayTipadoNumero = new int[3] { 1, 2, 3 };
var arrayTipadoNumero = new int[3];
arrayTipadoNumero[0] = 5;
arrayTipadoNumero[1] = 5;
arrayTipadoNumero[2] = 10;

// Array.Resize(ref arrayTipadoNumero, 100);

// arrayTipadoNumero[10] = 100;

foreach (var item in arrayTipadoNumero)
{
    Console.WriteLine(item);
}

// var arrayTipadoString = new string[2] { "Rafael", "Almeida" };
var arrayTipadoString = new string[2];
arrayTipadoString[0] = "Rafael";
arrayTipadoString[1] = "Almeida";

foreach (var item in arrayTipadoString)
{
    Console.WriteLine(item);
}
*/

var lista = new List<string>(10)
{
    "Rafael",
    "Almeida"
};
// lista.Add("Rafael");
// lista.Add("Almeida");
// lista.Add("Curso");

var nome = lista[0];
Console.WriteLine(nome);

lista.RemoveAt(1);

foreach (var item in lista)
{
    Console.WriteLine(item);
}
