/*
Console.WriteLine("a"=="a");
Console.WriteLine("a"=="A");
Console.WriteLine(1==2);

string myValue = "a";
Console.WriteLine(myValue=="a");

string value1 = "A";
string value2 = "a ";

Console.WriteLine(value1==value2);
Console.WriteLine(value1==value2.Trim());
Console.WriteLine(value1.ToLower()==value2.Trim()); */

/*

string pangram = "The quick brown fox jumps over the lazy dog";
Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("Fox"));
Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxx");
// These two lines of code will create the same output

Console.WriteLine(pangram.Contains("fox") == false);
Console.WriteLine(!pangram.Contains("fox"));
Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxx");
//< evaluate this condition > ? <if condition is true, return this value > : <if condition is false, return this value >
Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxx");

int valorVenda = 1000;
string nome="João";

Console.WriteLine(valorVenda > 1000 ? 100 : 50);

string msg= nome!="Joãoaa" ? "Olá, João!" : "Olá, visitante!";
Console.WriteLine(msg); */










//heads ou tails

//Random random=new();
//int moeda=random.Next(0,2);

/*
for (int i = 0; i < 1000000; i++)
{
    int moeda = Random.Shared.Next(0, 2);
    string res = moeda == 1 ? "Heads" : "Tails";
    Console.WriteLine(res);
}
*/
/*
string permission = "Admin|Manager";
int level = 55;

string passe;
int nivel;

Console.WriteLine("Enter your permission:");
passe = Console.ReadLine();
Console.WriteLine("Enter your level:");
nivel = int.Parse(Console.ReadLine());

if (!permission.Contains(passe))
{
    Console.WriteLine("You do not have sufficient privileges.");
}
else
{

    if (passe == "Admin" && nivel > level)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else if (passe == "Admin" && nivel <= level)
    {
        Console.WriteLine("Welcome, Admin user.");
    }
    else if (passe == "Manager" && nivel >= level - 35)
    {
        Console.WriteLine("Contact an Admin for access.");
    }
    else if (passe == "Manager" && nivel < level - 35)
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }

}
*/

string permission = "Admin|Manager";
int level = 55;

if (permission.Contains("Admin"))
{
    Console.WriteLine(
        level > 55 ? "Welcome, Super Admin user." : "Welcome, Admin user."
    );
}
else if (permission.Contains("Manager"))
{
    Console.WriteLine(
        level >= 20 ? "Contact an Admin for access." : "You do not have sufficient privileges."
    );
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}
