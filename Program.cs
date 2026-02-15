/*A matriz ourAnimals inclui as seguintes "características de animal de estimação" para cada animal:

ID do animal de estimação #.
Espécies de animais de estimação (gato ou cachorro).
Idade do animal de estimação (anos).
Uma descrição das características/condição física do animal de estimação.
Uma descrição da personalidade do animal de estimação.
O apelido do animal de estimação.*/
bool vagaEncontrada = false;
string[,] ourAnimals = new string[8, 6];
//primeira dimensão anuimal,segunda dimensão característica

for (int i = 0; i < 8; i++)
{
    if (i == 0)
    {
        ourAnimals[i, 0] = "ID #: C1";
        ourAnimals[i, 1] = "cachorro";
        ourAnimals[i, 2] = "2";
        ourAnimals[i, 3] = "porte médio marron";
        ourAnimals[i, 4] = "brincalhão";
        ourAnimals[i, 5] = "Rex";
    }
    else if (i == 1)
    {
        ourAnimals[i, 0] = "ID #: G1";
        ourAnimals[i, 1] = "gato";
        ourAnimals[i, 2] = "1";
        ourAnimals[i, 3] = "pequeno branco";
        ourAnimals[i, 4] = "calmo";
        ourAnimals[i, 5] = "Mimi";

    }
    else
        ourAnimals[i, 0] = "";
    ourAnimals[i, 1] = "";
    ourAnimals[i, 2] = "";
    ourAnimals[i, 3] = "";
    ourAnimals[i, 4] = "";
    ourAnimals[i, 5] = "";
    {

    }

}
string menuSelection = "";

while (menuSelection != "Sair")
{
    Console.WriteLine("1. Listar todos os animais de estimação");
    Console.WriteLine("2. Adicionar novo animal de estimação");
    Console.WriteLine("3. Digite 'Sair' para encerrar");

    menuSelection = Console.ReadLine();

    if (menuSelection == "1")
    {
        for (int i = 0; i < 8; i++)
        {
            if (!string.IsNullOrEmpty(ourAnimals[i, 0]))
            {
                Console.WriteLine($"ID: {ourAnimals[i, 0]}");
                Console.WriteLine($"Espécie: {ourAnimals[i, 1]}");
                Console.WriteLine($"Idade: {ourAnimals[i, 2]} anos");
                Console.WriteLine($"Características: {ourAnimals[i, 3]}");
                Console.WriteLine($"Personalidade: {ourAnimals[i, 4]}");
                Console.WriteLine($"Apelido: {ourAnimals[i, 5]}");
                Console.WriteLine("-----------------------------");
            }
        }

    }
    else if (menuSelection == "2")
    {
        for (int i = 0; i < 8; i++)
        {
            if (String.IsNullOrEmpty(ourAnimals[i, 0])) { }
            Console.WriteLine("Adicionando novo animal de estimação...");

            vagaEncontrada = true;

            ourAnimals[i, 0] = "ID #" + (i + 1);

            string especie = "";
            while (especie != "gato" && especie != "cachorro")
            {
                Console.Write("Espécie (gato ou cachorro): ");
                especie = Console.ReadLine().ToLower();
                if (especie != "gato" && especie != "cachorro")
                {
                    Console.WriteLine("Espécie inválida. Por favor, digite 'gato' ou 'cachorro'.");
                }
            }
            ourAnimals[i, 1] = especie;
            
            Console.Write("Idade: ");
            ourAnimals[i, 2] = Console.ReadLine();

            Console.Write("Descrição física: ");
            ourAnimals[i, 3] = Console.ReadLine();

            Console.Write("Personalidade: ");
            ourAnimals[i, 4] = Console.ReadLine();

            Console.Write("Apelido: ");
            ourAnimals[i, 5] = Console.ReadLine();

            break;
        }
        if (!vagaEncontrada)
        {
            
        }
    }
    else if (menuSelection != "Sair")
    {
        Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
    }
}