string[] myStrings = ["I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices"];
int periodLocation;


foreach (string item in myStrings)
{
    string myString = item;
    periodLocation = myString.IndexOf(".");

    while (periodLocation >= 0)
    {
        string frase = myString.Substring(0, periodLocation);
        Console.WriteLine(frase);

        myString = myString.Remove(0, periodLocation + 1);
        myString = myString.TrimStart();
        periodLocation = myString.IndexOf(".");

    }
    Console.WriteLine(myString.Length > 0 ? myString : "");
}

/* saída
I like pizza
I like roast chicken
I like salad
I like all three of the menu choices 
*/