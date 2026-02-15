//Crie um array de 5 nomes de frutas e imprima cada um usando for e foreach.
string[] frutas = ["uva", "banana", "maçã", "pera", "graviola"];

foreach (string item in frutas)
{
    Console.WriteLine(item);
}
Console.WriteLine("-------------------");
for (int i = 0; i < frutas.Length; i++)
{
    Console.WriteLine(frutas[i]);

}
//Crie um array 2D que armazene 3 alunos e 2 notas (matriz 3x2). Calcule a média de cada aluno.

string[,] array2D = new string[3, 3];

array2D[0, 0] = "Anderson";
array2D[0, 1] = "7";
array2D[0, 2] = "9";

array2D[1, 0] = "Soares";
array2D[1, 1] = "6";
array2D[1, 2] = "5";


array2D[2, 0] = "Andrade";
array2D[2, 1] = "10";
array2D[2, 2] = "6";


for (int i = 0; i < array2D.GetLength(0); i++)
{
    double nota1 = double.Parse(array2D[i, 1]);
    double nota2 = double.Parse(array2D[i, 2]);

    double media = (nota1 + nota2) / 2;


    Console.WriteLine($"{array2D[i, 0]} - Nota 1: {nota1} - Nota 2: {nota2} - Média: {media}");

}
//Transforme o array de frutas em uma List<string> e adicione mais 3 frutas. Imprima todas.
List<string> frutasList = new List<string>();

foreach (string item in frutas)
{
    frutasList.Add(item);
}
foreach (var item in frutasList)
{
    Console.WriteLine(item);
}

//Exercício bônus: peça para o usuário digitar nomes de pessoas até digitar “sair” e armazene em uma lista.
List<string> nomes = new List<string>();
string input = "";
Console.WriteLine("Digite um nome (ou 'sair' para encerrar): ");
do
{
    input = Console.ReadLine();
    if (input.ToLower() != "sair")
    {
        nomes.Add(input);
    }


} while (input.ToLower() != "sair");
