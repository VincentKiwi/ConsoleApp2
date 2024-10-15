using System;
using System.Collections.Generic;

public class tamagotchi
{
private int hunger;
private int boredom;
private List<string> words = new List<string>() {"booonk"};
private bool isAlive;
public string name;

public tamagotchi()
{
    isAlive = true;
}

public void Feed()
{
    Console.WriteLine($"[{name}] is fed, [{name}] is becoming more full ");
    hunger -= 2;
    if (hunger < 0)
    {
        hunger = 0;
    }
}
public void word()
{
    int wordNum =RandomAccess.Shared.Next(words.Count);
    Console.WriteLine($"[{name}] i know:{words[wordNum]}");
    ReduceBoredom();
}
private void learn(string word)
{
    Console.WriteLine($("[{name}] learns: {word}"));
    words.Add(word);
    ReduceBoredome();
}

public void Run()
{
    hunger++;
    boredom++;
    if (hunger > 10 || boredom > 10)
    {
        isAlive = false;
    }
}
 public void printstats()
 {
    Console.WriteLine($"name = ______ hunger= {hunger}______ bordom = {boredom} _____ learned words = {word.Count} ");
 }
public bool GetAlive()
{
    return isAlive;
}





}
