
using System.Transactions;

Console.WriteLine("hello come to tama land");

tamagotchi MyTama = new tamagotchi();

Console.WriteLine($"what name do you want type+enter");
MyTama.name = "Console.ReadLine()";

Console.WriteLine("great {MyTama.name} is the best u could come up with");
Console.WriteLine("enter");
Console.ReadKey();

while (MyTama.GetAlive() == true)
{
    Console.Clear();
    MyTama.printstats();
    Console.WriteLine("what do u want");
    Console.WriteLine($"1. learn {MyTama.name} a word  ");
    Console.WriteLine($"2. speak to {MyTama.name}");
    Console.WriteLine($"3. feed {MyTama.name}");
    Console.WriteLine($"do jack shit");

    string Act = Console.ReadLine();
    if (Act == "1")
    {
        Console.WriteLine("what word");
        string word = Console.ReadLine();
        MyTama.learn(word);
    }
    if (Act == "2")
    {
        MyTama.word();
    }
    if (Act == "3")
    {
        MyTama.Feed();
    }
    else
    {Console.WriteLine("doing nothing");}
    MyTama.Run();
    Console.WriteLine("press enter to continue");
    Console.ReadLine();



}
    Console.WriteLine(" ohhhhhhh shit tama died");
    Console.WriteLine("enter to end");
    Console.ReadLine();


